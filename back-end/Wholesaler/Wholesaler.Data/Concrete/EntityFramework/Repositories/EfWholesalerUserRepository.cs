using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Entities.Concrete;
using Wholesaler.Data.Abstract;
using Wholesaler.Shared.Data.Concrete.EntityFramework;

namespace Wholesaler.Data.Concrete.EntityFramework.Repositories
{
    public class EfWholesalerUserRepository : EfEntityRepositoryBase<WholesalerUser>, IWholesalerUserRepository
    {
        public EfWholesalerUserRepository(DbContext context) : base(context)
        {
        }
    }
}
