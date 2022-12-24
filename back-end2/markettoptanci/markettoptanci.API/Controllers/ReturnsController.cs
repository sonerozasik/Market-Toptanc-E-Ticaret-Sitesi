using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnsController : ControllerBase
    {
        private IReturnService _returnItemService;
        public ReturnsController()
        {
            _returnItemService = new ReturnManager();
        }


        [HttpGet]
        public List<Return> GetAllReturns()
        {
            return _returnItemService.GetAllReturns();
        }

        [HttpGet("{id}")]
        public Return GetReturnById(int id)
        {
            return _returnItemService.GetReturnById(id);
        }

        [HttpPost]
        public Return CreateReturn([FromBody] Return returnItem)
        {
            return _returnItemService.CreateReturn(returnItem);
        }

        [HttpPut]
        public Return UpdateReturn([FromBody] Return returnItem)
        {
            return _returnItemService.UpdateReturn(returnItem);
        }

        [HttpDelete("{id}")]
        public Return DeleteReturn(int id)
        {
            return _returnItemService.DeleteReturn(id);
        }
    }
}

