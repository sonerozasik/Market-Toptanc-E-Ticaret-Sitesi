using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IStockRepository
    {
        List<Stock> GetAllStocks();

        Stock GetStockById(int id);

        Stock CreateStock(Stock stock);

        Stock UpdateStock(Stock stock);

        Stock DeleteStock(int id);
    }
}
