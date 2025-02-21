using CleanArchitectureUtility.Core.Domain.Events;

namespace KevinTemplate.Core.Domain.People.Events;

public record PersonCreated(Guid Id, string FirstName, string LastName) : IDomainEvent;