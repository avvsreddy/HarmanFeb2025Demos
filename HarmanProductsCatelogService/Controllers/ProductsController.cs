using HarmanProductsCatelogService.DataLayer;
using HarmanProductsCatelogService.Entities;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HarmanProductsCatelogService.Controllers
{
    [Route("api/[controller]")] // URI GET https://www.harman.com/api/products
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {

        private IProductsCatalogRepository repo;

        public ProductsController(IProductsCatalogRepository repo)
        {
            this.repo = repo;
        }

        // URI : GET  .../api/products
        [HttpGet]
        [EnableQuery]
        public IQueryable<Product> GetProducts()
        {
            return repo.GetProducts().AsQueryable();

        }

        #region old get endpoints


        // endpoint to return product by id
        // Design the endpoint
        // GET .../api/products/1234
        // Map uri with action method
        [HttpGet]
        [Route("{id:int}")]
        [Produces(typeof(Product))]
        [ProducesResponseType(StatusCodes.Status200OK)]  // Returns 200 with data
        [ProducesResponseType(StatusCodes.Status404NotFound)] // Returns 404 if student not found
        //[Authorize]
        [AllowAnonymous]
        public IActionResult GetProductById(int id)
        {
            var product = repo.GetProductById(id);
            if (product != null)
            {
                return Ok(product); // return data + status code - 200
            }
            // return status code not found - 404
            return NotFound();

        }

        // get all products by category
        // Design the URI
        // GET .../api/products/category/mobiles
        [HttpGet]
        [Route("category/{category:alpha}")]
        public IActionResult GetProductByCategory(string category)
        {
            var products = repo.GetProductsByCategory(category);
            if (products != null && products.Count > 0)
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Get all products by brand
        // GET .../api/products/brand/harman
        [HttpGet]
        [Route("brand/{brand:alpha}")]
        public IActionResult GetProductByBrand(string brand)
        {
            var products = repo.GetProductsByBrand(brand);
            if (products != null && products.Count > 0)
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Get Costliest product
        // GET .../api/products/costliest

        [HttpGet("costliest")]
        public IActionResult GetCostliestProduct()
        {
            return Ok(repo.GetProducts().OrderByDescending(p => p.Price).FirstOrDefault());
        }


        // get cheapest product
        [HttpGet("cheapest")]
        public IActionResult GetCheapestProduct()
        {
            return Ok(repo.GetProducts().OrderBy(p => p.Price).FirstOrDefault());
        }

        // get products between amount 1 and amount 2
        // GET .../api/products/min/{5000}/max/{6000}
        // GET .../api/products/between/{5000}/and/{6000}

        // get all products by country
        // GET .../api/products/country/{country}
        // get all available products
        // GET /api/products/available

        #endregion



        // delete a resouce by id

        // DELETE .../api/products/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var productToDel = repo.GetProductById(id);
            if (productToDel != null)
            {
                repo.Delete(id);
                return Ok();
            }
            return NotFound("");

        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            // do validation
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }
            repo.Insert(product);
            // status code - 201 - Created
            // Location - URI
            // data 

            return Created($"api/products/{product.Id}", product);
        }
        [HttpPut]
        [Route("{id}")] // PUT .../api/products/1
        public IActionResult Put(int id, [FromBody] Product product)
        {
            var p = repo.GetProductById(id);
            if (p == null)
            {
                return NotFound();
            }
            // do validation
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }

            repo.Update(product);
            return Ok();

        }


    }
}
