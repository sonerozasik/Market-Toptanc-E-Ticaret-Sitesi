using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;

namespace markettoptanci.Business.Concrete
{
    public class StockManager : IStockService
    {
        private IStockRepository _stockRepository;

        public StockManager()
        {
            _stockRepository = new StockRepository();
        }
        public Stock CreateStock(Stock stock)
        {
            return _stockRepository.CreateStock(stock);
        }

        public Stock DeleteStock(int id)
        {
            return _stockRepository.DeleteStock(id);
        }

        public List<Stock> GetAllStocks()
        {
            return _stockRepository.GetAllStocks();
        }

        public Stock GetStockById(int id)
        {
            if (id > 0)
            {
                return _stockRepository.GetStockById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public Stock UpdateStock(Stock stock)
        {
            return _stockRepository.UpdateStock(stock);
        }
    }
}
