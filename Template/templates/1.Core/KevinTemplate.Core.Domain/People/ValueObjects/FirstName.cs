using CleanArchitectureUtility.Core.Common.Utilities;
using CleanArchitectureUtility.Core.Domain.ValueObjects;
using KevinTemplate.Core.Domain.People.Exceptions;

namespace KevinTemplate.Core.Domain.People.ValueObjects;

public class FirstName : StringVO
{
    public FirstName(string value) : base(value.Trim())
    {
    }

    protected override void Validate(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new PersonFirstNameNullException();
        if (!value.IsLengthBetween(2, 50))
            throw new PersonFirstNameStringLengthException(2, 50);
    }
}