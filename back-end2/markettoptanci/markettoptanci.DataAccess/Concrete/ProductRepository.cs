﻿using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
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
    }
}
