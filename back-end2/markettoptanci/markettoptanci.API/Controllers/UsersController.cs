using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController()
        {
            _userService = new UserManager();
        }


        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public User CreateUser([FromBody]User user)
        {
            return _userService.CreateUser(user);
        }

        [HttpPut]
        public User UpdateUser([FromBody] User user)
        {
            return _userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public User DeleteUser(int id)
        {
            return _userService.DeleteUser(id);
        }

        [HttpGet("login/{username}/{password}")]

        public bool Login(string username,string password)
        {
            User user = _userService.GetUserByUsername(username);
            if (user.PasswordHash == password)
            {
                return true;
            }
            return false;
        }
    }
}

