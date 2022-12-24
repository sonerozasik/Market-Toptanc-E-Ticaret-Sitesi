using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController
    {
        private IStockService _stockService;
        public StocksController()
        {
            _stockService = new StockManager();
        }


        [HttpGet]
        public List<Stock> GetAllStocks()
        {
            return _stockService.GetAllStocks();
        }

        [HttpGet("{id}")]
        public Stock GetStockById(int id)
        {
            return _stockService.GetStockById(id);
        }

        [HttpPost]
        public Stock CreateStock([FromBody] Stock stock)
        {
            return _stockService.CreateStock(stock);
        }

        [HttpPut]
        public Stock UpdateStock([FromBody] Stock stock)
        {
            return _stockService.UpdateStock(stock);
        }

        [HttpDelete("{id}")]
        public Stock DeleteStock(int id)
        {
            return _stockService.DeleteStock(id);
        }
    }
}
