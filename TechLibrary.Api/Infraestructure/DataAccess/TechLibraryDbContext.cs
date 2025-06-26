using Microsoft.EntityFrameworkCore;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure.DataAccess
{

    public class TechLibraryDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Medicamento> Medicamento { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\analu\\Downloads\\TechLibraryDb.db");
        }
    }
}
