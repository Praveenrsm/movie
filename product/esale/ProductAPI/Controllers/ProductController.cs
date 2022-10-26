using Microsoft.AspNetCore.Mvc;
using ProductBL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productservice;
        public ProductController(ProductService productservice)
        {
            _productservice = productservice;
        }
        [HttpGet("GetProduct")]
        public IEnumerable<Product> GetProduct()
        {
            return _productservice.GetProducts();
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product pro)
        {
            _productservice.AddProduct(pro);
            return Ok("Product created successfully");
        }
        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int ProductId)
        {
            _productservice.DeleteProduct(ProductId);
            return Ok("Product deleted successfully");
        }
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product pro)
        {
            _productservice.UpdateProduct(pro);
            return Ok("Product updated successfully");
        }
        [HttpGet("GetProductById")]
        public Product GetProductById(int ProductId)
        {
            return _productservice.GetProductById(ProductId);
        }
    }
}
