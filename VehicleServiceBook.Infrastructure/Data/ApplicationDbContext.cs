using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VehicleServiceBook.Infrastructure.Data.Models;

namespace VehicleServiceBook.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarService> CarServices { get; set; }

        public DbSet<Garage> Garages { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<ServiceHistory> ServiceHistories { get; set; }
    }
}