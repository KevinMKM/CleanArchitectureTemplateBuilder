using KevinTemplate.Core.Domain.People.Entities;
using Microsoft.EntityFrameworkCore;

namespace KevinTemplate.Infra.Data.Sql
{
    public interface ISharedDbSets
    {
        public DbSet<Person> Persons { get; set; }
        // Add all your DbSet properties here
    }
}