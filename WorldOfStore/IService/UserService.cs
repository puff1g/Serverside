using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldOfStore.Common;
using WorldOfStore.Models;

namespace WorldOfStore.IService
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            return Global.Users;
        }

        public User Login(User user)
        {
            var UserEX = Global.Users.SingleOrDefault(x=>x.UserName == user.UserName);

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.Password, user.Password);

            if(isValidPassword)
            {
                return user;
            }
            return null;
        }

        public User Signup(User user) 
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            Global.Users.Add(user);
            return user;
        }
    }
}
