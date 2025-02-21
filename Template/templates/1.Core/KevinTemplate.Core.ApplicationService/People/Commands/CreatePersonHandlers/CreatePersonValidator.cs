using CleanArchitectureUtility.Extensions.Abstractions.Translations;
using FluentValidation;
using KevinTemplate.Core.Contract.People.Commands;
using KevinTemplate.Core.Domain.People.Entities;

namespace KevinTemplate.Core.ApplicationService.People.Commands.CreatePersonHandlers;

public class CreatePersonValidator : AbstractValidator<CreatePerson>
{
    public CreatePersonValidator(ITranslator translator)
    {
        RuleFor(c => c.FirstName).NotEmpty()
            .WithMessage(translator[$"The value of {nameof(Person.FirstName)} should not be null"]);
        RuleFor(c => c.LastName).NotEmpty()
            .WithMessage(translator[$"The value of {nameof(Person.FirstName)} should not be null"]);
    }
}