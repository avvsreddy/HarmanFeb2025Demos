using HarmanProductsCatelogService.Entities;
using Microsoft.EntityFrameworkCore;

namespace HarmanProductsCatelogService.DataLayer
{
    public class ProductsCatalogDbContext : DbContext
    {
        // map to database



        public ProductsCatalogDbContext(DbContextOptions<ProductsCatalogDbContext> options) : base(options) { }




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HarmanProductsCatalogDb2025;Integrated Security=True");
        //    }
        //}





        // map to tables

        public DbSet<Product> Products { get; set; }
    }
}
