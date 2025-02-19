using EFDemoApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFDemoApp.DataLayer
{
    public class ProductsDbContext : DbContext
    {
        // 1. Map to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsDb2025;Integrated Security=True");
        }



        // 2. Map to tables

        public DbSet<Product> Products { get; set; }

    }
}
