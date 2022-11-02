using Microsoft.AspNetCore.Mvc;
using SkynetApp.API.Services;

namespace SkynetApp.API.Controllers
{
    [ApiController]
    [Route(template: "api/[controller]")]
    public class ProductController : ControllerBase
    {
        
        private IProductService _product;
        public ProductController(IProductService product)
            {
            _product = product;
}
        [HttpGet(template: "products")]
        public string GetAllProducts()
        {
            return _product.GetAllProducts();
        }
    }
}
