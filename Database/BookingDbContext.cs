using BookingSystem_Hairdresser.Database.Tables;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem_Hairdresser.Database
{
    public class BookingDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hairdresser> Hairdressers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.CustomerId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Hairdresser)
                .WithMany(h => h.Appointments)
                .HasForeignKey(a => a.HairdresserId);
        }
    }
}
