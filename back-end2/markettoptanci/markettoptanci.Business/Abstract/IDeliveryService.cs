using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IDeliveryService
    {
        List<Delivery> GetAllDeliveries();

        Delivery GetDeliveryById(int id);

        Delivery CreateDelivery(Delivery delivery);

        Delivery UpdateDelivery(Delivery delivery);

        Delivery DeleteDelivery(int id);
    }
}
