using CleanArchitectureUtility.Core.Domain.Exceptions;
using KevinTemplate.Core.Domain.People.Entities;

namespace KevinTemplate.Core.Domain.People.Exceptions
{
    public class PersonFirstNameNullException : InvalidValueObjectStateException
    {
        public PersonFirstNameNullException() : base($"The value of {nameof(Person.FirstName)} should not be null")
        {
        }
    }

    public class PersonFirstNameStringLengthException : InvalidValueObjectStateException
    {
        public PersonFirstNameStringLengthException(int minLength, int maxLength)
            : base($"The Length of {nameof(Person.FirstName)} should be {minLength} - {maxLength}")
        {
        }
    }
}