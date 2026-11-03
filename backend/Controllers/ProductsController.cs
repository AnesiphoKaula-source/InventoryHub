using Microsoft.AspNetCore.Mvc;
using InventoryHub.Models;

namespace InventoryHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Quantity = 20,
                    Price = 999.99M
                },
                new Product
                {
                    Id = 2,
                    Name = "Keyboard",
                    Quantity = 100,
                    Price = 49.99M
                }
            };

            return Ok(products);
        }
    }
}
