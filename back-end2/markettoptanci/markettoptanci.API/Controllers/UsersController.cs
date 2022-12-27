using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
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
        public ActionResult<List<User>>  GetAllUsers()
        {
            List<User> users = _userService.GetAllUsers();
            if (users == null)
            {
                return NotFound();
            }
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            User user = _userService.GetUserById(id);
            if(user== null)
            {
                return NotFound();
            }
            return user;
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

        public ActionResult<User> Login(string username,string password)
        {
            User user = _userService.GetUserByUsername(username);
            if (user.PasswordHash == password)
            {
                return user;
            }
            return BadRequest("False Password!");
        }
    }
}

