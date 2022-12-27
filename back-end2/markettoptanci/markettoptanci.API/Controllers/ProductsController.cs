using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using markettoptanci.Entities.Modals;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController()
        {
            _productService = new ProductManager();
        }


        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Product CreateProduct([FromBody] Product product)
        {
            return _productService.CreateProduct(product);
        }

        [HttpPut]
        public Product UpdateProduct([FromBody] Product product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public Product DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }

        [HttpPost("listOfProducts")]
        public List<Product> AddListOfProduct([FromBody] List<ProductWithStock> productList)
        {
            return _productService.AddListOfProduct(productList);
        }

        [HttpGet("byWSUId/{wholeSalerUserId}")]

        public List<Product> GetProductsByWholeSalerUserId(int wholeSalerUserId)
        {
            return _productService.GetProductsByWholeSalerUserId(wholeSalerUserId);
        }

        [HttpGet("filter/{productName}/{minPrice}/{maxPrice}/{wholeSalerUserName}/{category}")]
        public List<Product> GetProductsFiltered(string productName, int minPrice, int maxPrice, string wholeSalerUserName, int category)
        {
            return _productService.GetProductsFiltered(productName, minPrice, maxPrice, wholeSalerUserName, category);
        }
    }
}

