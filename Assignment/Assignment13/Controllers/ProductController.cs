

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment13.Models;

namespace Assignment13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        static List<Product> products = new List<Product>()
        {
                new Product{ Id = 1, Name = "Laptop",Price = 10000000},
                new Product{ Id = 2, Name = "Phone",Price = 80000},
                new Product{ Id = 3, Name = "Earphone",Price = 5000},
                new Product{ Id = 4, Name = "Charger",Price = 1000},
           
        };

        [HttpGet]

        public IActionResult Getproduct()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult getProductById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]

        public IActionResult AddProduct(Product product)
        {
            products.Add(product);

            return Ok(product);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateProducts(int id, Product product)
        {
            var product1 = products.FirstOrDefault(x => x.Id == id);
            if(product1 == null)
            {
                return NotFound();
            }
            product1.Price  = product.Price;
            return Ok(product1);
        }

        [HttpGet("Name/{name}")]

        public IActionResult getProductByName(string name)
        {
            var result = products.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase )).ToList();

            if (!result.Any())
            {
                return NotFound("No product found under this name");
            }
            return Ok(result);
        }

    }
}