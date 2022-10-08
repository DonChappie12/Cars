using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using carsBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace carsBackEnd.Controllers
{
    public class JwtPacket
    {
        public string Token { get; set; }
        public string FirstName { get; set; }
    }
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // *** Hard code User for testing ***
        // User users = new User
        // {
        //     new 
        // }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            User user1 = new User()
            {
                FirstName = "David",
                LastName = "Mendez",
                Email = "test@test.com",
                PhoneNumber = "(123) 456-7890",
                Gender = "Male",
                Age = 20
            };

            User user2 = new User()
            {
                FirstName = "Mary",
                LastName = "Hernandez",
                Email = "test1@test1.com",
                PhoneNumber = "(234) 567-8901",
                Gender = "Female",
                Age = 24
            };

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            // Todo: Get all users from hard coded data
            return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        // Todo: This method is to create a JWT token but not yet fully implemented for login/register
        JwtPacket CreateJwtToken(User user)
        {
            var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MY_KEY_THAT_IS_SECRET"));
            var signinCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, Convert.ToString(user.Id))
            };

            var jwt = new JwtSecurityToken(claims: claims, signingCredentials: signinCredentials);
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new JwtPacket { Token = encodedJwt, FirstName = user.FirstName };
        }
    }
}
