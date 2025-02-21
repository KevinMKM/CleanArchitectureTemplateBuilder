using CleanArchitectureUtility.Infra.Data.SqlCommands;
using Microsoft.EntityFrameworkCore;

namespace KevinTemplate.Infra.Data.SqlCommand.Common;

public class KevinTemplateCommandDbContext : BaseCommandDbContext
{
    public KevinTemplateCommandDbContext(DbContextOptions<KevinTemplateCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}