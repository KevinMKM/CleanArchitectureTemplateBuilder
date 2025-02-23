using CleanArchitectureUtility.Extensions.Abstractions.UsersManagements;
using CleanArchitectureUtility.Infra.Data.SqlQueries;
using KevinTemplate.Core.Domain.People.Entities;
using KevinTemplate.Infra.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace KevinTemplate.Infra.Data.SqlQuery.Common;

public class KevinTemplateQueryDbContext : BaseQueryDbContext, ISharedDbSets
{
    public KevinTemplateQueryDbContext(DbContextOptions options, IUserInfoService userInfoService)
        : base(options, userInfoService)
    {
    }

    public DbSet<Person> Persons { get; set; }
}