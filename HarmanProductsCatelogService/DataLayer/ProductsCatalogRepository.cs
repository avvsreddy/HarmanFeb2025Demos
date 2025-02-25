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

        public void Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
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
            return db.Products.Where(p => p.Brand.Contains(brand)).ToList();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return db.Products.Where(p => p.Category.Contains(category)).ToList();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Update(Product product)
        {

            //db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            //db.Products.Update(product);

            var p = db.Products.Find(product.Id);

            p.Name = product.Name;
            p.Price = product.Price;
            p.Category = product.Category;
            p.Brand = product.Brand;
            p.Country = product.Country;
            p.IsAvailable = product.IsAvailable;
            // use auto mapper

            db.SaveChanges();
        }
    }
}
