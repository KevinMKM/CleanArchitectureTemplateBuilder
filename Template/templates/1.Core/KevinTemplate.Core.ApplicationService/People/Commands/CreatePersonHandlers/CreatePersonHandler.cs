using CleanArchitectureUtility.Core.ApplicationServices.Commands;
using CleanArchitectureUtility.Core.Contract.ApplicationServices.Commands;
using KevinTemplate.Core.Contract.People.Commands;
using KevinTemplate.Core.Domain.People.Entities;
using KevinTemplate.Core.Domain.People.ValueObjects;

namespace KevinTemplate.Core.ApplicationService.People.Commands.CreatePersonHandlers;

internal class CreatePersonHandler : CommandHandler<CreatePerson, Guid>
{
    private readonly IPersonCommandRepository _repository;

    public CreatePersonHandler(IServiceProvider serviceProvider, IPersonCommandRepository repository) : base(serviceProvider)
    {
        _repository = repository;
    }

    public override async Task<CommandResult<Guid>> Handle(CreatePerson request)
    {
        Person person = new(new FirstName(request.FirstName), new LastName(request.LastName));
        await _repository.InsertAsync(person);
        await _repository.CommitAsync();
        return await OkAsync(person.Id.Value);
    }
}