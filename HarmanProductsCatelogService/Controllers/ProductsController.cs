using HarmanProductsCatelogService.DataLayer;
using HarmanProductsCatelogService.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HarmanProductsCatelogService.Controllers
{
    [Route("api/[controller]")] // URI GET https://www.harman.com/api/products
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductsCatalogRepository repo;

        public ProductsController(IProductsCatalogRepository repo)
        {
            this.repo = repo;
        }

        // URI : GET  .../api/products
        [HttpGet]
        public List<Product> GetProducts()
        {
            // send a request to dal then return the result

            //ProductsCatalogDbContext db = new ProductsCatalogDbContext();


            return repo.GetProducts();



            //return new List<Product>()
            //{
            //    //new Product{Id=111, Name="Product 1", Price=1000},
            //    //new Product{Id=222, Name="Product 2", Price=2000},
            //    //new Product{Id=333, Name="Product 3", Price=3000},
            //    //new Product{Id=444, Name="Product 4", Price=4000},
            //    //new Product{Id=555, Name="Product 5", Price=5000},
            //};

        }



    }
}
