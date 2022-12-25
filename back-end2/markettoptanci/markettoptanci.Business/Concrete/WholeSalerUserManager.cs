using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;

namespace markettoptanci.Business.Concrete
{
    public class WholeSalerUserManager : IWholeSalerUserService
    {
        private IWholeSalerUserRepository _wholeSalerUserRepository;

        public WholeSalerUserManager()
        {
            _wholeSalerUserRepository = new WholeSalerUserRepository();
        }
        public WholeSalerUser CreateWholeSalerUser(WholeSalerUser wholeSalerUser)
        {
            return _wholeSalerUserRepository.CreateWholeSalerUser(wholeSalerUser);
        }

        public WholeSalerUser DeleteWholeSalerUser(int id)
        {
            return _wholeSalerUserRepository.DeleteWholeSalerUser(id);
        }

        public List<WholeSalerUser> GetAllWholeSalerUsers()
        {
            return _wholeSalerUserRepository.GetAllWholeSalerUsers();
        }

        public WholeSalerUser GetWholeSalerUserById(int id)
        {
            if (id > 0)
            {
                return _wholeSalerUserRepository.GetWholeSalerUserById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public WholeSalerUser UpdateWholeSalerUser(WholeSalerUser wholeSalerUser)
        {
            return _wholeSalerUserRepository.UpdateWholeSalerUser(wholeSalerUser);
        }

        public WholeSalerUser GetWholeSalerUserByUserId(int userId)
        {
            return _wholeSalerUserRepository.GetWholeSalerUserByUserId(userId);
        }
    }
}
