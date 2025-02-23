using CleanArchitectureUtility.Core.Domain.Entities;
using KevinTemplate.Core.Domain.People.Events;
using KevinTemplate.Core.Domain.People.ValueObjects;

namespace KevinTemplate.Core.Domain.People.Entities;

public class Person : AggregateRoot
{
    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }

    public Person(FirstName firstName, LastName lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        AddEvent(new PersonCreated(Id.Value, firstName.Value, lastName.Value));
    }

    public Person(string firstName, string lastName)
    {
        FirstName = new FirstName(firstName);
        LastName = new LastName(lastName);
        AddEvent(new PersonCreated(Id.Value, firstName, lastName));
    }
}