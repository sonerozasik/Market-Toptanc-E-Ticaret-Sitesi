using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.Entities;

namespace markettoptanci.Business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAllStocks();

        Stock GetStockById(int id);

        Stock CreateStock(Stock stock);

        Stock UpdateStock(Stock stock);

        Stock DeleteStock(int id);
    }
}
