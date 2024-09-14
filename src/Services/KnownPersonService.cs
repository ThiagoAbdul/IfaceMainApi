using IfaceMainApi.Data;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.Models.Templates;
using IfaceMainApi.src.Models.DTOs.Out;
using Microsoft.EntityFrameworkCore;
using System;

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

    public async Task<Result<object>> AddImage(Guid knownPersonId, string embedding, IFormFile file)
    {
        KnownPerson? knownPerson = await _dbContext.KnownPersons
           .FirstOrDefaultAsync(x => x.Id == knownPersonId);

        if (knownPerson == null)
            return Result<object>.Error("Conhecido não encontrado");

        string url = file.FileName;

        Photo photo = new()
        {
            Url = url,
            Embedding = embedding,
            KnownPerson = knownPerson
        };

        await _dbContext.Photos.AddAsync(photo);

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
