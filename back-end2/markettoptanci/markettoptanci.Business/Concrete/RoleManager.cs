using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleRepository _roleRepository;

        public RoleManager()
        {
            _roleRepository = new RoleRepository();
        }
        public Role CreateRole(Role role)
        {
            return _roleRepository.CreateRole(role);
        }

        public Role DeleteRole(int id)
        {
            return _roleRepository.DeleteRole(id);
        }

        public List<Role> GetAllRoles()
        {
            return _roleRepository.GetAllRoles();
        }

        public Role GetRoleById(int id)
        {
            if (id > 0)
            {
                return _roleRepository.GetRoleById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public Role UpdateRole(Role role)
        {
            return _roleRepository.UpdateRole(role);
        }
    }
}
