using CleanArchitectureUtility.Infra.Data.SqlCommands;
using KevinTemplate.Core.Contract.People.Commands;
using KevinTemplate.Core.Domain.People.Entities;
using KevinTemplate.Infra.Data.SqlCommand.Common;

namespace KevinTemplate.Infra.Data.SqlCommand.People;

public class PersonCommandRepository : BaseCommandRepository<Person, KevinTemplateCommandDbContext>, IPersonCommandRepository
{
    public PersonCommandRepository(KevinTemplateCommandDbContext dbContext) : base(dbContext)
    {
    }
}