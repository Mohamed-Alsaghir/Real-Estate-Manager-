
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Ass5DAL
{
    public class Ass5Context : DbContext
    {
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}EstateManagement.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estate>()
                .HasOne(e => e.Address)
                .WithOne()
                .HasForeignKey<Estate>(e => e.AddressId)
                .OnDelete(DeleteBehavior.Cascade); // Add cascade delete
        }

        public void EnsureDatabaseCreated()
        {
            this.Database.EnsureCreated();
        }
    }

}
