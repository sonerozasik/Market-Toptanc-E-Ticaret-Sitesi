using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IGroceryStoreUserService
    {
        List<GroceryStoreUser> GetAllGroceryStoreUsers();

        GroceryStoreUser GetGroceryStoreUserById(int id);

        GroceryStoreUser CreateGroceryStoreUser(GroceryStoreUser groceryStoreUser);

        GroceryStoreUser UpdateGroceryStoreUser(GroceryStoreUser groceryStoreUser);

        GroceryStoreUser DeleteGroceryStoreUser(int id);
    }
}
