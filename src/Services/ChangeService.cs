using IfaceMainApi.Data;
using IfaceMainApi.Models.DTOs.Out;
using IfaceMainApi.Models.Templates;
using Microsoft.EntityFrameworkCore;
using IfaceMainApi.Models.Enums;
using IfaceMainApi.Models.Entities;
using IfaceMainApi.src.Models.DTOs.Out;

namespace IfaceMainApi.src.Services;

public class ChangeService(AppDbContext dbContext, ILogger<ChangeService> logger)
{

    public async Task<Result<IEnumerable<ChangeResponse>>> GetChangesForPwad(Guid pwadId)
    {

        var changes = await dbContext.Changes
            .Where(x => x.PwadId == pwadId && x.Sync == false)
            .AsNoTracking()
            .ToListAsync();

        if (changes.Count == 0)
            return Result<IEnumerable<ChangeResponse>>.Success([]);

        var changeResponses = await CreateChangeResponses(changes);

        return Result<IEnumerable<ChangeResponse>>.Success(changeResponses);
        
            
    }

    private async Task<IEnumerable<ChangeResponse>> CreateChangeResponses(IEnumerable<Change> changes)
    {
        List<ChangeResponse> changesResponses = [];

        var knownPersonsChangesIds = changes.Where(x =>
                x.Entity == AppEntity.KnownPerson
                && x.Operation != ChangeOperation.DELETE
                && x.RegisterId != null)
            .Select(x => x.RegisterId);

        if(knownPersonsChangesIds.Any())
        {
            var knownPersons = await dbContext.KnownPersons
                .Where(x => knownPersonsChangesIds.Contains(x.Id))
                .Include(x => x.Person)
                .AsNoTracking()
                .ToListAsync();

            knownPersons.ForEach(x =>
            {
                Change? change = changes.FirstOrDefault(change => change.RegisterId == x.Id);
                if (change != null)
                {
                    changesResponses.Add(new ChangeResponse(change, new KnownPersonResponse(x)));
                }

            });
        }


        var imagesChangesIds = changes.Where(x =>
                    x.Entity == AppEntity.Image
                && x.Operation != ChangeOperation.DELETE
                && x.RegisterId != null)
            .Select(x => x.RegisterId);

        if(imagesChangesIds.Any())
        {
            var images = await dbContext.Images
                 .Where(x => imagesChangesIds.Contains(x.Id))
                 .AsNoTracking()
                 .ToListAsync();

            images.ForEach(async x =>
            {
                Change? change = changes.FirstOrDefault(change => change.RegisterId == x.Id);
                if (change != null)
                {
                    changesResponses.Add(new ChangeResponse(change, new ImageResponse(x)));
                }
            });

        }

        return changesResponses;
    }

    public async Task SyncAll(Guid pwadId)
    {
        await dbContext.Changes
            .Where(c => c.PwadId == pwadId)
            .ExecuteUpdateAsync(c => c.SetProperty(x => x.Sync, true));
    }
}
