using CleanArchitectureUtility.Core.Domain.Exceptions;
using KevinTemplate.Core.Domain.People.Entities;

namespace KevinTemplate.Core.Domain.People.Exceptions
{
    public class PersonLastNameNullException : InvalidValueObjectStateException
    {
        public PersonLastNameNullException() : base($"The value of {nameof(Person.LastName)} should not be null")
        {
        }
    }

    public class PersonLastNameStringLengthException : InvalidValueObjectStateException
    {
        public PersonLastNameStringLengthException(int minLength, int maxLength)
            : base($"The Length of {nameof(Person.LastName)} should be {minLength} - {maxLength}")
        {
        }
    }
}