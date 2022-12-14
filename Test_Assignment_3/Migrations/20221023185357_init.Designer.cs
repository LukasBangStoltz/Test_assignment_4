// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Test_Assignment_3.Context;

#nullable disable

namespace Test_Assignment_3.Migrations
{
    [DbContext(typeof(DBApplicationContext))]
    [Migration("20221023185357_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Test_Assignment_3.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Date = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5399),
                            EmployeeId = 1,
                            End = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5402),
                            Start = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5402)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Date = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5404),
                            EmployeeId = 2,
                            End = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5404),
                            Start = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5404)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 2,
                            Date = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5405),
                            EmployeeId = 1,
                            End = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5405),
                            Start = new DateTime(2022, 10, 23, 18, 53, 57, 284, DateTimeKind.Utc).AddTicks(5405)
                        });
                });

            modelBuilder.Entity("Test_Assignment_3.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustomerId"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sebastian",
                            LastName = "Hansen"
                        },
                        new
                        {
                            CustomerId = 2,
                            Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Phil",
                            LastName = "Andersen"
                        });
                });

            modelBuilder.Entity("Test_Assignment_3.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Dr. Isenborg",
                            LastName = "isenborg@gmail.com"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Dr. Wegner",
                            LastName = "wegner@gmail.com"
                        });
                });

            modelBuilder.Entity("Test_Assignment_3.Models.Booking", b =>
                {
                    b.HasOne("Test_Assignment_3.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Assignment_3.Models.Employee", "Employee")
                        .WithMany("Bookings")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Test_Assignment_3.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Test_Assignment_3.Models.Employee", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
