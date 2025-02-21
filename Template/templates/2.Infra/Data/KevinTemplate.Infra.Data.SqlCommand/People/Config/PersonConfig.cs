using KevinTemplate.Core.Domain.People.Entities;
using KevinTemplate.Core.Domain.People.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KevinTemplate.Infra.Data.SqlCommand.People.Config;

public class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.Property(c => c.FirstName).HasConversion(c => c.Value, c => new FirstName(c));
        builder.Property(c => c.LastName).HasConversion(c => c.Value, c => new LastName(c));
    }
}