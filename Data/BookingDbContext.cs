﻿using BookingSystem_Hairdresser.Tables;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem_Hairdresser.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hairdresser> Hairdressers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

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

