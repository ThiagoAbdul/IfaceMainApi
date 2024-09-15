using IfaceMainApi.Data;
using Microsoft.EntityFrameworkCore;

namespace IfaceMainApi.Configurations;

public static class DatabaseCreation
{
    public static void ApplyDatabaseCreation(this WebApplication application)
    {
        using var scope = application.Services.CreateScope();

        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        dbContext.Database.EnsureCreated();

        dbContext.Database.Migrate();
    }
}
