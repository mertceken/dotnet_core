using DotNetWithElastic.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWithElastic.Context
{
    public sealed class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TravelDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Vacation> Vacations { get; set; }

        
    }


}
