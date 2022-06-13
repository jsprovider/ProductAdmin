using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAdmin.DomainEntity;
using ProductAdmin.ServiceInterface;

namespace ProductAdmin.Api.Controllers
{
 

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
           var results = await _productService.GetProductAll();
            return Ok(results);
        }

    }
}
