using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldOfStore.Models;

namespace WorldOfStore.IService
{
    public interface IUserService
    {
        User Signup(User oUser);

        User Login(User oUser);
        List<User> GetAllUsers();
    }
}
