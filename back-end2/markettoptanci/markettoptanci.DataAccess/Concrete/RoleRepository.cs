using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        public Role CreateRole(Role role)
        {
            using (var roleDbContext = new UserDbContext())
            {
                roleDbContext.Roles.Add(role);
                roleDbContext.SaveChanges();
                return role;
            }
        }

        public Role DeleteRole(int id)
        {
            using (var roleDbContext = new UserDbContext())
            {
                var deleteRole = GetRoleById(id);
                roleDbContext.Roles.Remove(deleteRole);
                roleDbContext.SaveChanges();
                return deleteRole;
            }
        }

        public Role GetRoleById(int id)
        {
            using (var roleDbContext = new UserDbContext())
            {
                return roleDbContext.Roles.Find(id);
            }
        }

        public List<Role> GetAllRoles()
        {
            using (var roleDbContext = new UserDbContext())
            {
                return roleDbContext.Roles.ToList();
            }
        }

        public Role UpdateRole(Role role)
        {
            using (var roleDbContext = new UserDbContext())
            {
                roleDbContext.Roles.Update(role);
                roleDbContext.SaveChanges();
                return role;
            }
        }
    }
}
