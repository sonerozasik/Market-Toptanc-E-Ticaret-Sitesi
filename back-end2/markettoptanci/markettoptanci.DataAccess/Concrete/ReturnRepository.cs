using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class ReturnRepository : IReturnRepository
    {
        public Return CreateReturn(Return returnItem)
        {
            using (var returnItemDbContext = new UserDbContext())
            {
                returnItemDbContext.Returns.Add(returnItem);
                returnItemDbContext.SaveChanges();
                return returnItem;
            }
        }

        public Return DeleteReturn(int id)
        {
            using (var returnItemDbContext = new UserDbContext())
            {
                var deleteReturn = GetReturnById(id);
                returnItemDbContext.Returns.Remove(deleteReturn);
                returnItemDbContext.SaveChanges();
                return deleteReturn;
            }
        }

        public Return GetReturnById(int id)
        {
            using (var returnItemDbContext = new UserDbContext())
            {
                return returnItemDbContext.Returns.Find(id);
            }
        }

        public List<Return> GetAllReturns()
        {
            using (var returnItemDbContext = new UserDbContext())
            {
                return returnItemDbContext.Returns.ToList();
            }
        }

        public Return UpdateReturn(Return returnItem)
        {
            using (var returnItemDbContext = new UserDbContext())
            {
                returnItemDbContext.Returns.Update(returnItem);
                returnItemDbContext.SaveChanges();
                return returnItem;
            }
        }
    }
}
