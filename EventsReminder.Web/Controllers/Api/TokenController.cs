using EventsReminder.Model.Models;
using EventsReminder.Model.ViewModels.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace EventsReminder.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TokenController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateToken([FromBody]LoginViewModel login)
        {
            IActionResult response = Unauthorized();
            var result = Authenticate(login);

            if (result)
            {
                var tokenString = BuildToken();
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string BuildToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Data:Token:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Data:Token:Issuer"],
              _configuration["Data:Token:Issuer"],
              expires: DateTime.Now.AddMinutes(1),
              signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private bool Authenticate(LoginViewModel login)
        {
            if (login.Email == _configuration["Data:DispatchNotificationUser:Email"] && login.Password == _configuration["Data:DispatchNotificationUser:Password"])
            {
                return true;
            }

            return false;
        }
    }
}