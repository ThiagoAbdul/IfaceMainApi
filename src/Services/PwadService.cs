using IfaceMainApi.Data;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Models.Templates;
using IfaceMainApi.src.Models.DTOs.In;
using IfaceMainApi.src.Models.DTOs.Out;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IfaceMainApi.src.Services;

public class PwadService(AppDbContext appDbContext, ILogger<PwadService> logger)
{
    private readonly AppDbContext _dbContext = appDbContext;
    private readonly ILogger<PwadService> _logger = logger; 

    public async Task<Result<PwadResponse>> Create(CreatePwadRequest request, Guid caregiverAuthId)
    {
        var caregiver = await _dbContext.Caregivers
            .FirstOrDefaultAsync(e => e.AuthId == caregiverAuthId);

        if (caregiver == null)
            return Result<PwadResponse>.Error("Cuidador não encontrado");

        Person person = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        try
        {
            await _dbContext.Persons.AddAsync(person);

            PersonWithAlzheimerDisease pwad = new()
            {
                Person = person,
                MainCaregiver = caregiver
            };

            await _dbContext.PersonWithAlzheimerDisease.AddAsync(pwad);

            string carefulToken = Guid.NewGuid().ToString();

            Careful careful = new()
            {   
                Caregiver = caregiver,
                Pwad = pwad,
                CarefulToken = carefulToken
            };

            await _dbContext.Carefuls.AddAsync(careful);

            await _dbContext.SaveChangesAsync();

            var response = new PwadResponse()
            {
                Id = caregiver.Id,
                Person = new PersonResponse(person),
                CarefulToken = carefulToken
            };

            return Result<PwadResponse>.Success(response);

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return Result<PwadResponse>.Error("Falha ao cadastrar Portador de Mal de Alzheimer");
        }
    }

    public async Task<Result<PwadResponse>> RegisterDevice(RegisterPwadDeviceRequest request)
    {
        Careful? careful = await _dbContext.Carefuls
            .Include(c => c.Pwad)
            .ThenInclude(p => p.Person)
            .FirstOrDefaultAsync(c => c.CarefulToken == request.CarefulToken);

        if (careful == null)
            return Result<PwadResponse>.Error("Cadastro não encontrado");

        if(careful.Pwad == null)
            return Result<PwadResponse>.Error("Cadastro não encontrado");

        try
        {
            careful.Pwad.DeviceToken = request.DeviceToken;
            await _dbContext.SaveChangesAsync();

            PwadResponse response = new()
            {
                CarefulToken = request.CarefulToken,
                Id = careful.Pwad.Id,
                Person = new PersonResponse(careful.Pwad.Person)
            };

            return Result<PwadResponse>.Success(response);
        }
        catch (Exception)
        {
            return Result<PwadResponse>.Error("Falha ao cadastrar dispositivo");
        }

    }

    public async Task<Result<KnownPersonResponse>> AddKownPerson(Guid pwadId, CreateKnowPersonRequest request)
    {
        PersonWithAlzheimerDisease? pwad = await _dbContext.PersonWithAlzheimerDisease
            .FirstOrDefaultAsync(p => p.Id == pwadId);

        if (pwad == null)
            return Result<KnownPersonResponse>.Error("NotFound");

        Person person = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        await _dbContext.Persons.AddAsync(person);

        KnownPerson knownPerson = new()
        {
            Person = person,
            Description = request.Description,
            PersonWithAlzheimersDiseaseId = pwad.Id
        };

        await _dbContext.AddAsync(knownPerson);

        await _dbContext.SaveChangesAsync();

        KnownPersonResponse response = new(knownPerson);

        return Result<KnownPersonResponse>.Success(response);
    }

    public async Task<Result<IEnumerable<KnownPersonResponse>>> GetAllKnownPersonsByPwadId(Guid pwadId)
    {
        List<KnownPerson> knownPeople = await _dbContext.KnownPersons
            .Where(k => k.PersonWithAlzheimersDiseaseId == pwadId)
            .Include(k => k.Person)
            .AsNoTracking()
            .ToListAsync();

        return Result<IEnumerable<KnownPersonResponse>>
            .Success(knownPeople.Select(k => new KnownPersonResponse(k)));
    }

    public async Task<Result<PwadResponse>> GetPwadById(Guid pwadId)
    {
        PersonWithAlzheimerDisease? pwad = await _dbContext.PersonWithAlzheimerDisease
            .Include(x => x.Person)
            .FirstOrDefaultAsync(x => x.Id == pwadId);

        if (pwad == null)
            return Result<PwadResponse>.Error("Portafor de Alzheimer não encontrado");

        PwadResponse response = new()
        {
            Id = pwad.Id,
            Person = new PersonResponse(pwad.Person), // TODO
            CarefulToken = ""
            
            
        };

        return Result<PwadResponse>.Success(response);
    }

}
