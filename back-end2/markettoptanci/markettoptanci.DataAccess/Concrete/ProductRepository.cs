using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using markettoptanci.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var productDbContext = new UserDbContext())
            {
                productDbContext.Products.Add(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public Product DeleteProduct(int id)
        {
            using (var productDbContext = new UserDbContext())
            {
                var deleteProduct = GetProductById(id);
                productDbContext.Products.Remove(deleteProduct);
                productDbContext.SaveChanges();
                return deleteProduct;
            }
        }

        public Product GetProductById(int id)
        {
            using (var productDbContext = new UserDbContext())
            {
                return productDbContext.Products.Find(id);
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var productDbContext = new UserDbContext())
            {
                List<Product> products = productDbContext.Products.ToList();
                foreach (var product in products)
                {
                    Stock stock = new Stock();
                    WholeSalerUser wholeSalerUser = new WholeSalerUser();
                    stock = productDbContext.Stocks.Find(product.StockId);
                    wholeSalerUser = productDbContext.WholeSalerUsers.Find(product.WholeSalerUserId);
                    product.Stock = stock;
                    product.WholeSalerUser = wholeSalerUser;
                }
                return products;
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var productDbContext = new UserDbContext())
            {
                productDbContext.Products.Update(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public List<Product> AddListOfProduct(List<ProductWithStock> productList)
        {
            using (var productDbContext = new UserDbContext())
            {
                var products = new List<Product>();
                foreach (var productWithStock in productList)
                {
                    Stock stock = new Stock();
                    stock.Quantity = productWithStock.Quantity;
                    stock.StockType = productWithStock.StockType;
                    stock.Description = productWithStock.Description;
                    //productDbContext.Stocks.Add(stock);

                    Product product = new Product();
                    product.ProductName = productWithStock.ProductName;
                    product.Thumbnail = "empty";
                    product.WholeSalerUserId = productWithStock.WholeSalerUserId;
                    product.CategoryId = productWithStock.CategoryId;
                    product.StockId = stock.Id;
                    product.Stock = stock;
                    product.Price = productWithStock.Price;
                    productDbContext.Products.Add(product);
                    products.Add(product);
                }
                productDbContext.SaveChanges();
                return products;
            }
        }

        public List<Product> GetProductsByWholeSalerUserId(int wholeSalerUserId)
        {
            using (var productDbContext = new UserDbContext())
            {
                List<Product> products = productDbContext.Products.Where(p=>p.WholeSalerUserId == wholeSalerUserId).ToList();
                foreach (var product in products)
                {
                    Stock stock = new Stock();
                    WholeSalerUser wholeSalerUser = new WholeSalerUser();
                    stock = productDbContext.Stocks.Find(product.StockId);
                    wholeSalerUser = productDbContext.WholeSalerUsers.Find(product.WholeSalerUserId);
                    product.Stock = stock;
                    product.WholeSalerUser = wholeSalerUser;
                }
                return products;
            }
        }

        public List<Product> GetProductsFiltered(string productName,int minPrice,int maxPrice,string wholeSalerUserName,int category)
        {
            if (productName == "$") productName = "";
            if (wholeSalerUserName == "$") wholeSalerUserName = "";

            using (var productDbContext = new UserDbContext())
            {
                List<Product> products = new List<Product>();
                List<WholeSalerUser> wholeSalerUsers = productDbContext.WholeSalerUsers.Where(w => w.CompanyName.Contains(wholeSalerUserName)).ToList();
                foreach (var wholeSalerUser in wholeSalerUsers)
                {
                    if(category==0)  products.AddRange(productDbContext.Products.Where(p => p.ProductName.Contains(productName) && p.Price >= minPrice && p.Price <= maxPrice && p.WholeSalerUserId == wholeSalerUser.Id).ToList());
                    else  products.AddRange(productDbContext.Products.Where(p => p.ProductName.Contains(productName) && p.Price >= minPrice && p.Price <= maxPrice && p.CategoryId == category && p.WholeSalerUserId == wholeSalerUser.Id).ToList());
                }
                foreach (var product in products)
                {
                    Stock stock = new Stock();
                    WholeSalerUser wholeSalerUser = new WholeSalerUser();
                    stock = productDbContext.Stocks.Find(product.StockId);
                    wholeSalerUser = productDbContext.WholeSalerUsers.Find(product.WholeSalerUserId);
                    product.Stock = stock;
                    product.WholeSalerUser = wholeSalerUser;
                }
                return products;
            }
        }

    }
}
