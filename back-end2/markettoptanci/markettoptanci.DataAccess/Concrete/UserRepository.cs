using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public User DeleteUser(int id)
        {
            using (var userDbContext = new UserDbContext())
            {
                var deleteUser = GetUserById(id);
                userDbContext.Users.Remove(deleteUser);
                userDbContext.SaveChanges();
                return deleteUser;
            }
        }

        public User GetUserById(int id)
        {
            using (var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public List<User> GetAllUsers()
        {
            using(var userDbContext = new UserDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User UpdateUser(User user)
        {
            using (var userDbContext = new UserDbContext())
            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public User GetUserByUsername(string username)
        {
            using (var userDbContext = new UserDbContext())
            {
                User user = userDbContext.Users.FirstOrDefault(u => u.UserName == username);
                return user;
            }
        }
    }
}
