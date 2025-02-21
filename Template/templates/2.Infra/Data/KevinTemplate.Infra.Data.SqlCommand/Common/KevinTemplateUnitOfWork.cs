using CleanArchitectureUtility.Infra.Data.SqlCommands;
using KevinTemplate.Core.Contract.Common;

namespace KevinTemplate.Infra.Data.SqlCommand.Common;

public class KevinTemplateUnitOfWork : BaseEntityFrameworkUnitOfWork<KevinTemplateCommandDbContext>, IKevinTemplateUnitOfWork
{
    public KevinTemplateUnitOfWork(KevinTemplateCommandDbContext dbContext) : base(dbContext)
    {
    }
}