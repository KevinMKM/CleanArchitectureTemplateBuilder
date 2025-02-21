using CleanArchitectureUtility.Infra.Data.SqlQueries;
using KevinTemplate.Core.Contract.People.Queries;
using KevinTemplate.Infra.Data.SqlQuery.Common;

namespace KevinTemplate.Infra.Data.SqlQuery.People;

public class PersonQueryRepository : BaseQueryRepository<KevinTemplateQueryDbContext>, IPersonQueryRepository
{
    public PersonQueryRepository(KevinTemplateQueryDbContext dbContext) : base(dbContext)
    {
    }
}