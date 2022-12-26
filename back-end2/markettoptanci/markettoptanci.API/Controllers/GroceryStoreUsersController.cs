using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryStoreUsersController : ControllerBase
    {
        private IGroceryStoreUserService _groceryStoreUserService;
        public GroceryStoreUsersController()
        {
            _groceryStoreUserService = new GroceryStoreUserManager();
        }


        [HttpGet]
        public List<GroceryStoreUser> GetAllGroceryStoreUsers()
        {
            return _groceryStoreUserService.GetAllGroceryStoreUsers();
        }

        [HttpGet("{id}")]
        public GroceryStoreUser GetGroceryStoreUserById(int id)
        {
            return _groceryStoreUserService.GetGroceryStoreUserById(id);
        }

        [HttpPost]
        public GroceryStoreUser CreateGroceryStoreUser([FromBody]GroceryStoreUser groceryStoreUser)
        {
            return _groceryStoreUserService.CreateGroceryStoreUser(groceryStoreUser);
        }

        [HttpPut]
        public GroceryStoreUser UpdateGroceryStoreUser([FromBody] GroceryStoreUser groceryStoreUser)
        {
            return _groceryStoreUserService.UpdateGroceryStoreUser(groceryStoreUser);
        }

        [HttpDelete("{id}")]
        public GroceryStoreUser DeleteGroceryStoreUser(int id)
        {
            return _groceryStoreUserService.DeleteGroceryStoreUser(id);
        }

        [HttpGet("getByUserId/{userId}")]
        public GroceryStoreUser GetGroceryStoreUserByUserId(int userId)
        {
            return _groceryStoreUserService.GetGroceryStoreUserByUserId(userId);
        }

    }
}

