using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Message.Data;
using Message.Domain;
using Message.Jwt;
using Message.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Message.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MessageDbContext context;
        private readonly IOptions<JwtSettings> jwtSettings;

        public UsersController(MessageDbContext context, IOptions<JwtSettings> options)
        {
            this.context = context;
            this.jwtSettings = options;
        }


        [HttpPost("register")]
        public async Task<ActionResult> Register(RegisterUserBindingModel userModel)
        {
            this.context.Users.Add(new User
            {
                Username = userModel.Username,
                Password = userModel.Password
            });

            await this.context.SaveChangesAsync();

            return this.Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(RegisterUserBindingModel userModel)
        {
            var userFromDb = this.context.Users
                .SingleOrDefault(u => u.Username == userModel.Username && u.Password == userModel.Password);

            if(userFromDb == null)
            {
                return this.BadRequest("Username or password is invalid!");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this.jwtSettings.Value.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userFromDb.Username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

             return this.Ok(token);
        }
    }
}