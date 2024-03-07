using Microsoft.EntityFrameworkCore;
using Smart_Building1.Model;

namespace Smart_Building1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<CitizenApartment> CitizenApartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitizenApartment>()
                .HasKey(ca => new { ca.CitizenId, ca.ApartmentId });

            modelBuilder.Entity<CitizenApartment>()
                .HasOne(ca => ca.Citizen)
                .WithMany(c => c.CitizenApartments)
                .HasForeignKey(ca => ca.CitizenId);

            modelBuilder.Entity<CitizenApartment>()
                .HasOne(ca => ca.Apartment)
                .WithMany(a => a.CitizenApartments)
                .HasForeignKey(ca => ca.ApartmentId);
        }
    }
}
