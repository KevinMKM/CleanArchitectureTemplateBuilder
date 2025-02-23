using CleanArchitectureUtility.Infra.Data.Sql;
using KevinTemplate.Core.Contract.Common;

namespace KevinTemplate.Infra.Data.SqlCommand.Common;

public class KevinTemplateUnitOfWork : BaseEntityFrameworkUnitOfWork<KevinTemplateCommandDbContext>, IKevinTemplateUnitOfWork
{
    public KevinTemplateUnitOfWork(KevinTemplateCommandDbContext dbContext) : base(dbContext)
    {
    }
}