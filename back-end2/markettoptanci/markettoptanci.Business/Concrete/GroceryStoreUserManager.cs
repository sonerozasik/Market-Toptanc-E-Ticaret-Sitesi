using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class GroceryStoreUserManager: IGroceryStoreUserService
    {
        private IGroceryStoreUserRepository _groceryStoreUserRepository;

        public GroceryStoreUserManager()
        {
            _groceryStoreUserRepository = new GroceryStoreUserRepository();
        }
        public GroceryStoreUser CreateGroceryStoreUser(GroceryStoreUser groceryStoreUser)
        {
            return _groceryStoreUserRepository.CreateGroceryStoreUser(groceryStoreUser);
        }

        public GroceryStoreUser DeleteGroceryStoreUser(int id)
        {
            return _groceryStoreUserRepository.DeleteGroceryStoreUser(id);
        }

        public List<GroceryStoreUser> GetAllGroceryStoreUsers()
        {
            return _groceryStoreUserRepository.GetAllGroceryStoreUsers();
        }

        public GroceryStoreUser GetGroceryStoreUserById(int id)
        {
            if (id > 0)
            {
                return _groceryStoreUserRepository.GetGroceryStoreUserById(id);
            }

            throw new Exception("Id can not be less than 1!");

            
        }

        public GroceryStoreUser UpdateGroceryStoreUser(GroceryStoreUser groceryStoreUser)
        {
            return _groceryStoreUserRepository.UpdateGroceryStoreUser(groceryStoreUser);
        }

        public GroceryStoreUser GetGroceryStoreUserByUserId(int userId)
        {
            return _groceryStoreUserRepository.GetGroceryStoreUserByUserId(userId);
        }

    }
}
