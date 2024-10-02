using IfaceMainApi.Data;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Models.Templates;
using IfaceMainApi.src.Models.DTOs.Out;
using Microsoft.EntityFrameworkCore;
using IfaceMainApi.Models.Enums;
using IfaceMainApi.Models.DTOs.In;


namespace IfaceMainApi.Services;

public class KnownPersonService(AppDbContext appDbContext, ILogger<KnownPersonService> logger)
{
    private readonly AppDbContext _dbContext = appDbContext;

    private readonly ILogger<KnownPersonService> _logger = logger;

    public async Task<Result<KnownPersonResponse>> GetKnownPersonById(Guid knownPersonId)
    {
        KnownPerson? knownPerson = await _dbContext.KnownPersons
            .Include(x => x.Person)
            .FirstOrDefaultAsync(x => x.Id == knownPersonId);

        if (knownPerson == null)
            return Result<KnownPersonResponse>.Error("Conhecido não encontrado");

        var response = new KnownPersonResponse(knownPerson);

        return Result<KnownPersonResponse>.Success(response);
    }

    public async Task<Result<object>> AddImage(Guid knownPersonId, AddImageRequest request)
    {
        KnownPerson? knownPerson = await _dbContext.KnownPersons
           .FirstOrDefaultAsync(x => x.Id == knownPersonId);

        if (knownPerson == null)
            return Result<object>.Error("Conhecido não encontrado");

        string url = "";

        Image image = new()
        {
            Url = url,
            Embedding = request.Embedding,
            KnownPerson = knownPerson
        };

        await _dbContext.AddAsync(image);



        Change change = new()
        {
            Entity = AppEntity.Image,
            Operation = ChangeOperation.CREATE,
            RegisterId = image.Id,
            PwadId = knownPerson.PersonWithAlzheimersDiseaseId
        };

        await _dbContext.AddAsync(change);

        await _dbContext.SaveChangesAsync();



        return Result<object>.Success(url);

    }

    //public async Task<Result<KnownPersonResponse>> Update(Guid knownPersonId)
    //{
    //    KnownPerson? knownPerson = await _dbContext.KnownPersons
    //        .FirstOrDefaultAsync(x => x.Id == knownPersonId);

    //    if (knownPerson == null)
    //        return Result<KnownPersonResponse>.Error("Conhecido não encontrado");


    //}
}
