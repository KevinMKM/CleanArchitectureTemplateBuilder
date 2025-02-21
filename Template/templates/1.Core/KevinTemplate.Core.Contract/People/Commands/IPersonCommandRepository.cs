using CleanArchitectureUtility.Core.Contract.Data.Commands;
using KevinTemplate.Core.Domain.People.Entities;

namespace KevinTemplate.Core.Contract.People.Commands;

public interface IPersonCommandRepository : ICommandRepository<Person>
{
}