using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.Entities;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IRoleRepository
    {
        List<Role> GetAllRoles();

        Role GetRoleById(int id);

        Role CreateRole(Role role);

        Role UpdateRole(Role role);

        Role DeleteRole(int id);
    }
}
