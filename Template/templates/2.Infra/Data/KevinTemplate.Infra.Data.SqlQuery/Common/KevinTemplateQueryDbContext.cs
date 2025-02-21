using CleanArchitectureUtility.Infra.Data.SqlQueries;
using Microsoft.EntityFrameworkCore;

namespace KevinTemplate.Infra.Data.SqlQuery.Common;

public class KevinTemplateQueryDbContext : BaseQueryDbContext
{
    public KevinTemplateQueryDbContext(DbContextOptions options) : base(options)
    {
    }
}