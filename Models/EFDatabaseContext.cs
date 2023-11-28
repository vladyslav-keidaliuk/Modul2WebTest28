using Microsoft.EntityFrameworkCore;

namespace Modul2WebTest28.Models
{
    public class EFDatabaseContext : DbContext
    {
        public EFDatabaseContext(DbContextOptions<EFDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Cloth> Cloths { get; set; }

    }
}
