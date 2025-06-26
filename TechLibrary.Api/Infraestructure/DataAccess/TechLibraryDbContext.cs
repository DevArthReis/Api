using Microsoft.EntityFrameworkCore;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure.DataAccess
{

    public class TechLibraryDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\arthu\\Downloads\\TechLibraryDb.db");
        }
    }
}
