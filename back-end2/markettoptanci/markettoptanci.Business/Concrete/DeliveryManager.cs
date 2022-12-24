using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class DeliveryManager : IDeliveryService
    {
        private IDeliveryRepository _deliveryRepository;

        public DeliveryManager()
        {
            _deliveryRepository = new DeliveryRepository();
        }
        public Delivery CreateDelivery(Delivery delivery)
        {
            return _deliveryRepository.CreateDelivery(delivery);
        }

        public Delivery DeleteDelivery(int id)
        {
            return _deliveryRepository.DeleteDelivery(id);
        }

        public List<Delivery> GetAllDeliveries()
        {
            return _deliveryRepository.GetAllDeliveries();
        }

        public Delivery GetDeliveryById(int id)
        {
            if (id > 0)
            {
                return _deliveryRepository.GetDeliveryById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public Delivery UpdateDelivery(Delivery delivery)
        {
            return _deliveryRepository.UpdateDelivery(delivery);
        }
    }
}
