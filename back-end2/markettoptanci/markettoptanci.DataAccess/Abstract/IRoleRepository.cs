using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using markettoptanci.Entities.Role;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IRoleRepository
    {
        List<Role> GetAllRole();

        Role GetRoleById(int id);

        Role CreateRole(Role role);

        Role UpdateRole(Role role);

        Role DeleteRole(int id);
    }
}
