using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldOfStore.Models;

namespace WorldOfStore.IService
{
    public interface IUserService
    {
        User Signup(User user);

        User Login(User user);
        List<User> GetAllUsers();
    }
}
