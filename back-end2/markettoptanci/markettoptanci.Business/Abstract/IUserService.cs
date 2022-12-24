using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        User GetUserById(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        User DeleteUser(int id);
    }
}
