using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class DeliveryRepository : IDeliveryRepository
    {
        public Delivery CreateDelivery(Delivery delivery)
        {
            using (var deliveryDbContext = new UserDbContext())
            {
                deliveryDbContext.Deliveries.Add(delivery);
                deliveryDbContext.SaveChanges();
                return delivery;
            }
        }

        public Delivery DeleteDelivery(int id)
        {
            using (var deliveryDbContext = new UserDbContext())
            {
                var deleteDelivery = GetDeliveryById(id);
                deliveryDbContext.Deliveries.Remove(deleteDelivery);
                deliveryDbContext.SaveChanges();
                return deleteDelivery;
            }
        }

        public Delivery GetDeliveryById(int id)
        {
            using (var deliveryDbContext = new UserDbContext())
            {
                return deliveryDbContext.Deliveries.Find(id);
            }
        }

        public List<Delivery> GetAllDeliveries()
        {
            using (var deliveryDbContext = new UserDbContext())
            {
                return deliveryDbContext.Deliveries.ToList();
            }
        }

        public Delivery UpdateDelivery(Delivery delivery)
        {
            using (var deliveryDbContext = new UserDbContext())
            {
                deliveryDbContext.Deliveries.Update(delivery);
                deliveryDbContext.SaveChanges();
                return delivery;
            }
        }
    }
}
