using Microsoft.EntityFrameworkCore;
using Test_Assignment_3.Models;

namespace Test_Assignment_3.Context
{
    public class DBApplicationContext : DbContext
    {
        public DBApplicationContext(DbContextOptions<DBApplicationContext> options): base(options) { }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            Seed(builder);
            base.OnModelCreating(builder);
        }

        private void Seed(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(
               new Customer { CustomerId = 1, FirstName = "pik", LastName = "Hansen" },
               new Customer { CustomerId = 2, FirstName = "satan", LastName = "Hansen" }
               );

            builder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, FirstName = "ost", LastName = "Hansen@gmail.com" },
                new Employee { EmployeeId = 2, FirstName = "okle", LastName = "Hansen@gmail.com" }
                );

            builder.Entity<Booking>().HasData(
                   new Booking { Id = 1, CustomerId = 1, EmployeeId = 1, Date = DateTime.UtcNow, Start = DateTime.UtcNow, End = DateTime.UtcNow },
                   new Booking { Id = 2, CustomerId = 2, EmployeeId = 2, Date = DateTime.UtcNow, Start = DateTime.UtcNow, End = DateTime.UtcNow },
                   new Booking { Id = 3, CustomerId = 2, EmployeeId = 1, Date = DateTime.UtcNow, Start = DateTime.UtcNow, End = DateTime.UtcNow }
                );
        }
    }
}
