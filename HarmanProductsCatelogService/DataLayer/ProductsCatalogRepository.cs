using HarmanProductsCatelogService.Entities;

namespace HarmanProductsCatelogService.DataLayer
{


    public class ProductsCatalogRepository : IProductsCatalogRepository
    {

        private ProductsCatalogDbContext db;

        public ProductsCatalogRepository(ProductsCatalogDbContext db)
        {
            this.db = db;
        }
        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string productName)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            throw new NotImplementedException();
        }
    }
}
