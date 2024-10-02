using IfaceMainApi.Data;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Models.Templates;
using IfaceMainApi.src.Models.DTOs.In;
using IfaceMainApi.src.Models.DTOs.Out;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace IfaceMainApi.Services;

public class CaregiverService(AppDbContext dbContext)
{


    public async Task<Result<CaregiverResponse>> FindCaregiverByAuthId(Guid authId)
    {
        var caregiver = await dbContext.Caregivers
            .Include(c => c.Person)
            .FirstOrDefaultAsync(c => c.AuthId == authId);
        if (caregiver == null)
            return Result<CaregiverResponse>.Error("Cuidador não encontrado");

        CaregiverResponse response = new(caregiver);

        return Result<CaregiverResponse>.Success(response);
    }

    public async Task<Result<CaregiverResponse>> CreateCaregiver(CreateCaregiverRequest request)
    {
        var foundCaregiver = await dbContext.Caregivers
            .Include(c => c.Person)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.AuthId == request.AuthId);

        if (foundCaregiver != null)
            return Result<CaregiverResponse>.Error("Cuidador já cadastrado");

        Person person = new()
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        try
        {
            await dbContext.Persons.AddAsync(person);

            Caregiver caregiver = new()
            {
                AuthId = request.AuthId,
                PersonId = person.Id,
                Person = person,
            };

            await dbContext.Caregivers.AddAsync(caregiver);

            await dbContext.SaveChangesAsync();

            CaregiverResponse response = new(caregiver);

            return Result<CaregiverResponse>.Success(response);
        }
        catch (Exception)
        {
            return Result<CaregiverResponse>.Error("Falha no cadastro de cuidador");
        }

    
    }

    public async Task<Result<IEnumerable<PwadMinResponse>>> GetAllPwadsByCaregiver(Guid authId)
    {
        Caregiver? caregiver = await dbContext.Caregivers
            .Include(c => c.Carefuls)
            .ThenInclude(c => c.Pwad)
            .ThenInclude(p => p.Person)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.AuthId == authId);

        if (caregiver == null)
            return Result<IEnumerable<PwadMinResponse>>.Error("Cuidador não encontrado");

        IEnumerable<PwadMinResponse> response = caregiver.Carefuls.Select(c => new PwadMinResponse
        {
            Id = c.PwadId,
            CarefulToken = c.CarefulToken,
            Person = new PersonResponse(c.Pwad.Person)
        });

        return Result<IEnumerable<PwadMinResponse>>.Success(response);
    }


}
