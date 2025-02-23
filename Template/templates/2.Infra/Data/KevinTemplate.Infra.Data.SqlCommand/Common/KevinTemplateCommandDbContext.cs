using CleanArchitectureUtility.Extensions.Abstractions.UsersManagements;
using CleanArchitectureUtility.Infra.Data.SqlCommands;
using KevinTemplate.Core.Domain.People.Entities;
using KevinTemplate.Infra.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace KevinTemplate.Infra.Data.SqlCommand.Common;

public class KevinTemplateCommandDbContext : BaseCommandDbContext, ISharedDbSets
{
    public KevinTemplateCommandDbContext(DbContextOptions<KevinTemplateCommandDbContext> options, IUserInfoService userInfoService)
        : base(options, userInfoService)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    public DbSet<Person> Persons { get; set; }
}