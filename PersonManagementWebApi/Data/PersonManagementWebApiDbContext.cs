using Microsoft.EntityFrameworkCore;
using PersonManagementWebApi.Model;

namespace PersonManagementWebApi.Data
{
    public class PersonManagementWebApiDbContext : DbContext
    {

        public PersonManagementWebApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source = database.db");
    }

}