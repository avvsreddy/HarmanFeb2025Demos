using HarmanProductsCatelogService.Entities;

namespace HarmanProductsCatelogService.DataLayer
{
    public interface IProductsCatalogRepository
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProductByName(string productName);
        List<Product> GetProductsByCountry(string country);

        List<Product> GetProductsByBrand(string brand);


    }
}
