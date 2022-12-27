using markettoptanci.Entities;
using markettoptanci.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        Product DeleteProduct(int id);
        List<Product> AddListOfProduct(List<ProductWithStock> productList);

        List<Product> GetProductsByWholeSalerUserId(int wholeSalerUserId);

        List<Product> GetProductsFiltered(string productName, int minPrice, int maxPrice, string wholeSalerUserName, int category);



    }
}
