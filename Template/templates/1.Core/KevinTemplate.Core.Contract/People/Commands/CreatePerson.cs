using CleanArchitectureUtility.Core.Contract.ApplicationServices.Commands;

namespace KevinTemplate.Core.Contract.People.Commands;

public class CreatePerson : ICommand<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}