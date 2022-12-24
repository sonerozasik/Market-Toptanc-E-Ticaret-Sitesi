using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private IDeliveryService _deliveryService;
        public DeliveriesController()
        {
            _deliveryService = new DeliveryManager();
        }


        [HttpGet]
        public List<Delivery> GetAllDeliveries()
        {
            return _deliveryService.GetAllDeliveries();
        }

        [HttpGet("{id}")]
        public Delivery GetDeliveryById(int id)
        {
            return _deliveryService.GetDeliveryById(id);
        }

        [HttpPost]
        public Delivery CreateDelivery([FromBody] Delivery delivery)
        {
            return _deliveryService.CreateDelivery(delivery);
        }

        [HttpPut]
        public Delivery UpdateDelivery([FromBody] Delivery delivery)
        {
            return _deliveryService.UpdateDelivery(delivery);
        }

        [HttpDelete("{id}")]
        public Delivery DeleteDelivery(int id)
        {
            return _deliveryService.DeleteDelivery(id);
        }
    }
}

