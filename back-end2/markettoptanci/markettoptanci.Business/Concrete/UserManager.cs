using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class UserManager: IUserService
    {
        private IUserRepository _userRepository;

        public UserManager()
        {
            _userRepository = new UserRepository();
        }
        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public User DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            if (id > 0)
            {
                return _userRepository.GetUserById(id);
            }

            throw new Exception("Id can not be less than 1!");

            
        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
