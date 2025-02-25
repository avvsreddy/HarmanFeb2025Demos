using HarmanProductsCatelogService.Entities;

namespace HarmanProductsCatelogService.DataLayer
{
    public interface IProductsCatalogRepository
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        List<Product> GetProductsByCategory(string category);
        Product GetProductByName(string productName);
        List<Product> GetProductsByCountry(string country);

        List<Product> GetProductsByBrand(string brand);


        void Delete(int id);
        void Insert(Product product);

        void Update(Product product);

    }
}
