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

        public User Login(User oUser)
        {
            var user = Global.Users.SingleOrDefault(x=>x.UserName == oUser.UserName);

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(oUser.Password, user.Password);

            if(isValidPassword)
            {
                return user;
            }
            return null;
        }

        public User Signup(User oUser)
        {
            oUser.Password = BCrypt.Net.BCrypt.HashPassword(oUser.Password);
            Global.Users.Add(oUser);
            return oUser;
        }
    }
}
