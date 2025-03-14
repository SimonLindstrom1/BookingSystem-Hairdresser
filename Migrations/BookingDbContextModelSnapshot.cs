﻿// <auto-generated />
using System;
using BookingSystem_Hairdresser.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingSystem_Hairdresser.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingSystem_Hairdresser.Database.Tables.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("HairdresserId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HairdresserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BookingSystem_Hairdresser.Database.Tables.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookingSystem_Hairdresser.Database.Tables.Hairdresser", b =>
                {
                    b.Property<int>("HairdresserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HairdresserId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HairdresserId");

                    b.ToTable("Hairdressers");
                });

            modelBuilder.Entity("BookingSystem_Hairdresser.Database.Tables.Appointment", b =>
                {
                    b.HasOne("BookingSystem_Hairdresser.Database.Tables.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingSystem_Hairdresser.Database.Tables.Hairdresser", "Hairdresser")
                        .WithMany("Appointments")
                        .HasForeignKey("HairdresserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Hairdresser");
                });

            modelBuilder.Entity("BookingSystem_Hairdresser.Database.Tables.Customer", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BookingSystem_Hairdresser.Database.Tables.Hairdresser", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
