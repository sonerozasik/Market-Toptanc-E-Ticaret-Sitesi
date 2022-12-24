using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class GroceryStoreUserRepository : IGroceryStoreUserRepository
    {
        public GroceryStoreUser CreateGroceryStoreUser(GroceryStoreUser groceryStoreUser)
        {
            using (var groceryStoreUserDbContext = new UserDbContext())
            {
                groceryStoreUserDbContext.GroceryStoreUsers.Add(groceryStoreUser);
                groceryStoreUserDbContext.SaveChanges();
                return groceryStoreUser;
            }
        }

        public GroceryStoreUser DeleteGroceryStoreUser(int id)
        {
            using (var groceryStoreUserDbContext = new UserDbContext())
            {
                var deleteGroceryStoreUser = GetGroceryStoreUserById(id);
                groceryStoreUserDbContext.GroceryStoreUsers.Remove(deleteGroceryStoreUser);
                groceryStoreUserDbContext.SaveChanges();
                return deleteGroceryStoreUser;
            }
        }

        public GroceryStoreUser GetGroceryStoreUserById(int id)
        {
            using (var groceryStoreUserDbContext = new UserDbContext())
            {
                return groceryStoreUserDbContext.GroceryStoreUsers.Find(id);
            }
        }

        public List<GroceryStoreUser> GetAllGroceryStoreUsers()
        {
            using(var groceryStoreUserDbContext = new UserDbContext())
            {
                return groceryStoreUserDbContext.GroceryStoreUsers.ToList();
            }
        }

        public GroceryStoreUser UpdateGroceryStoreUser(GroceryStoreUser groceryStoreUser)
        {
            using (var groceryStoreUserDbContext = new UserDbContext())
            {
                groceryStoreUserDbContext.GroceryStoreUsers.Update(groceryStoreUser);
                groceryStoreUserDbContext.SaveChanges();
                return groceryStoreUser;
            }
        }
    }
}
