using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using markettoptanci.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }
        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public Product DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            if (id > 0)
            {
                return _productRepository.GetProductById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public List<Product> AddListOfProduct(List<ProductWithStock> productList)
        {
            return _productRepository.AddListOfProduct(productList);
        }

        
        public List<Product> GetProductsByWholeSalerUserId(int wholeSalerUserId)
        {
            return _productRepository.GetProductsByWholeSalerUserId(wholeSalerUserId);
        }

        
        public List<Product> GetProductsFiltered(string productName, int minPrice, int maxPrice, string wholeSalerUserName, int category)
        {
            return _productRepository.GetProductsFiltered(productName, minPrice, maxPrice, wholeSalerUserName, category);
        }
    }
}
