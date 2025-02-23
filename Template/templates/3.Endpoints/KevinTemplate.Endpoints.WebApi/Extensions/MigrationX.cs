using KevinTemplate.Core.Domain.People.Entities;
using KevinTemplate.Infra.Data.SqlCommand.Common;
using Microsoft.EntityFrameworkCore;

namespace KevinTemplate.Endpoints.WebApi.Extensions;

public static class MigrationX
{
    public static WebApplication ConfigureMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<KevinTemplateCommandDbContext>();
        if (!dbContext.Database.CanConnect())
        {
            Console.WriteLine("Database does not exist. Creating database...");
            dbContext.Database.EnsureCreated();
            SeedData(dbContext);
            Console.WriteLine("Database created and seeded.");
        }
        else
        {
            Console.WriteLine("Database exists. Applying pending migrations...");
            dbContext.Database.Migrate();
            Console.WriteLine("Pending migrations applied.");
        }

        return app;
    }

    private static void SeedData(KevinTemplateCommandDbContext dbContext)
    {
        // Check if the database already has data
        if (dbContext.Persons.Any())
            return;

        // Add initial data
        dbContext.Persons.Add(new Person("Admin", "Admin"));
        dbContext.SaveChanges();
    }
}