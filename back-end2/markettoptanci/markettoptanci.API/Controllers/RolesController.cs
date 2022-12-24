using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController
    {
        private IRoleService _roleService;
        public RolesController()
        {
            _roleService = new RoleManager();
        }


        [HttpGet]
        public List<Role> GetAllRoles()
        {
            return _roleService.GetAllRoles();
        }

        [HttpGet("{id}")]
        public Role GetRoleById(int id)
        {
            return _roleService.GetRoleById(id);
        }

        [HttpPost]
        public Role CreateRole([FromBody] Role role)
        {
            return _roleService.CreateRole(role);
        }

        [HttpPut]
        public Role UpdateRole([FromBody] Role role)
        {
            return _roleService.UpdateRole(role);
        }

        [HttpDelete("{id}")]
        public Role DeleteRole(int id)
        {
            return _roleService.DeleteRole(id);
        }
    }
}
