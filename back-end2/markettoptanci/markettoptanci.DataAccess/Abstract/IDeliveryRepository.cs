using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IDeliveryRepository
    {
        List<Delivery> GetAllDeliveries();

        Delivery GetDeliveryById(int id);

        Delivery CreateDelivery(Delivery delivery);

        Delivery UpdateDelivery(Delivery delivery);

        Delivery DeleteDelivery(int id);
    }
}
