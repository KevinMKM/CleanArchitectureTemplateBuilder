using CleanArchitectureUtility.Core.Common.Utilities;
using CleanArchitectureUtility.Core.Domain.ValueObjects;
using KevinTemplate.Core.Domain.People.Exceptions;

namespace KevinTemplate.Core.Domain.People.ValueObjects;

public class LastName : StringVO
{
    public LastName(string value) : base(value.Trim())
    {
    }

    protected override void Validate(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new PersonLastNameNullException();
        if (!value.IsLengthBetween(2, 50))
            throw new PersonLastNameStringLengthException(2, 50);
    }
}