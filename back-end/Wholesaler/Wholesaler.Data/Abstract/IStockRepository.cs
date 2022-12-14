using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;
using Wholesaler.Shared.Entities.Data.Abstract;

namespace Wholesaler.Data.Abstract
{
    public interface IStockRepository: IEntityRepository<Stock>
    {
    }
}
