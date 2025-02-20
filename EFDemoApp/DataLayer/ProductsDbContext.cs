using EFDemoApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFDemoApp.DataLayer
{
    public class ProductsDbContext : DbContext
    {
        // 1. Map to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsDb2025;Integrated Security=True;MultipleActiveResultSets=True")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().UseTphMappingStrategy();
            //modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();
        }

        // 2. Map to tables

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Person> People { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Customer> Customers { get; set; }

    }
}
