using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldOfStore.IService;
using WorldOfStore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorldOfStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IUserService _userService = null;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]  // Works here 
        public User Signup([FromBody] User oUser) 
        {
            return _userService.Signup(oUser); 
        }

        [HttpGet("Login")]
        public User Login([FromBody] User oUser)
        {
            return _userService.Login(oUser);
        }

    }
}