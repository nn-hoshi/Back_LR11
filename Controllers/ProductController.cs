using Microsoft.AspNetCore.Mvc;
using WebApiLab.Models;

namespace WebApiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Keybord", Stock = 2 },
            new Product { Id = 2, Name = "Headphone", Stock = 5 }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(products);
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = products.Find(p => p.Id == id);
            return product == null ? NotFound() : Ok(product);
        }

        // POST api/products
        [HttpPost]
        public ActionResult<Product> Create([FromBody] Product product)
        {
            product.Id = products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
            products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product updatedProduct)
        {
            var index = products.FindIndex(p => p.Id == id);
            if (index == -1) return NotFound();

            updatedProduct.Id = id;
            products[index] = updatedProduct;
            return NoContent();
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null) return NotFound();

            products.Remove(product);
            return NoContent();
        }
    }
}