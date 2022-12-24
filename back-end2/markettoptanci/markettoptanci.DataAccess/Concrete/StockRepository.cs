using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.DataAccess.Abstract.IStockRepository;

namespace markettoptanci.DataAccess.Concrete
{
    public class StockRepository : IStockRepository
    {
        public Stock CreateStock(Stock stock)
        {
            using (var StockDbContext = new UserDbContext())
            {
                StockDbContext.Stocks.Add(stock);
                StockDbContext.SaveChanges();
                return stock;
            }
        }

        public Stock DeleteStock(int id)
        {
            using (var StockDbContext = new UserDbContext())
            {
                var deleteStock = GetStockById(id);
                StockDbContext.Stocks.Remove(deleteStock);
                StockDbContext.SaveChanges();
                return deleteStock;
            }
        }

        public Stock GetStockById(int id)
        {
            using (var StockDbContext = new UserDbContext())
            {
                return StockDbContext.Stocks.Find(id);
            }
        }

        public List<Stock> GetAllStocks()
        {
            using (var StockDbContext = new UserDbContext())
            {
                return StockDbContext.Stocks.ToList();
            }
        }

        public Stock UpdateStock(Stock stock)
        {
            using (var StockDbContext = new UserDbContext())
            {
                StockDbContext.Stocks.Update(stock);
                StockDbContext.SaveChanges();
                return stock;
            }
        }
    }
}
}
