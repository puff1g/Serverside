using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldOfStore.Models;

namespace WorldOfStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsecController : ControllerBase
    {
        private readonly AllContext _context;
        //private readonly IJwtAuthenticationManager jwtAuthenticationManager;
        //IJwtAuthenticationManager jwtAuthenticationManager,
        public LoginsecController(AllContext context)
        {
            _context = context;
        }

        // POST: api/Loginsec
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody]UserCred Cred)
        {
            var UserEx = _context.User.FirstOrDefault(u => u.UserName == Cred.UserName);
            if(UserEx != null)
            {
                return Forbid();
            }
            else
            {
                User user = new User
                {
                    UserName = Cred.UserName,
                    Password = BCrypt.Net.BCrypt.HashPassword(Cred.UserPassword),
                    IsAdmin = false
                };
                _context.User.Add(user);
                await _context.SaveChangesAsync();

                return Ok(user);
            }
            
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserCred Cred)
        {
            var UserEx = _context.User.FirstOrDefault(u => u.UserName == Cred.UserName);
            if(UserEx == null)
            {
                return Unauthorized();
            }
            else
            {
                if(!BCrypt.Net.BCrypt.Verify(Cred.UserPassword, UserEx.Password))
                {
                    return Unauthorized();
                }
                else
                {
                    //var token = Create token here! 
                    //var token = jwtAuthenticationManager.Authenticate(user);
                    return Ok(UserEx);
                }
            }
        }
        
    }
}
