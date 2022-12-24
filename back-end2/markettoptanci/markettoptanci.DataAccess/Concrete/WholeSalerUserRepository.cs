using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;

namespace markettoptanci.DataAccess.Concrete
{
    public class WholeSalerUserRepository : IWholeSalerUserRepository
    {
        public WholeSalerUser CreateWholeSalerUser(WholeSalerUser wholeSalerUser)
        {
            using (var WholeSalerUserDbContext = new UserDbContext())
            {
                WholeSalerUserDbContext.WholeSalerUsers.Add(wholeSalerUser);
                WholeSalerUserDbContext.SaveChanges();
                return wholeSalerUser;
            }
        }

        public WholeSalerUser DeleteWholeSalerUser(int id)
        {
            using (var WholeSalerUserDbContext = new UserDbContext())
            {
                var deleteWholeSalerUser = GetWholeSalerUserById(id);
                WholeSalerUserDbContext.WholeSalerUsers.Remove(deleteWholeSalerUser);
                WholeSalerUserDbContext.SaveChanges();
                return deleteWholeSalerUser;
            }
        }

        public WholeSalerUser GetWholeSalerUserById(int id)
        {
            using (var WholeSalerUserDbContext = new UserDbContext())
            {
                return WholeSalerUserDbContext.WholeSalerUsers.Find(id);
            }
        }

        public List<WholeSalerUser> GetAllWholeSalerUsers()
        {
            using (var WholeSalerUserDbContext = new UserDbContext())
            {
                return WholeSalerUserDbContext.WholeSalerUsers.ToList();
            }
        }

        public WholeSalerUser UpdateWholeSalerUser(WholeSalerUser wholeSalerUser)
        {
            using (var WholeSalerUserDbContext = new UserDbContext())
            {
                WholeSalerUserDbContext.WholeSalerUsers.Update(wholeSalerUser);
                WholeSalerUserDbContext.SaveChanges();
                return wholeSalerUser;
            }
        }
    }
}

