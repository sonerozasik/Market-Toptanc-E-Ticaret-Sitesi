using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wholesaler.Data.Abstract;
using Wholesaler.Entities.Concrete;
using Wholesaler.Shared.Data.Concrete.EntityFramework;

namespace Wholesaler.Data.Concrete.EntityFramework.Repositories
{
    public class EfCartItemRepository : EfEntityRepositoryBase<CartItem>, ICartItemRepository
    {
        public EfCartItemRepository(DbContext context) : base(context)
        {
        }
    }
}
