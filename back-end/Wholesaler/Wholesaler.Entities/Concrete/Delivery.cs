using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Shared.Entities.Abstract;

namespace Wholesaler.Entities.Concrete
{
    public class Delivery: EntityBase, IEntity
    {
        public string TrackNumber { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }
        public Order Order { get; set; }
    }
}
