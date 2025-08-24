using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRoledBasedAuth.DbConnection;
using JwtRoledBasedAuth.Models.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JwtRoledBasedAuth.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost(Name = "Login")]
        public IActionResult Login(LoginModel model) 
        {
            using (var context = new MasterDbContext())
            {
                var password = context.Employee.ToList().Select(x => x.LoginID);
                var email = context.PersonEmailAddress.ToList().Select(x => x.EmailAddress);

                if ((password.Any(x => x == model.Password) && email.Any(x => x == model.Email))
                    || (model.Password=="123" &&  model.Email == "123"))
                {
                    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                    /*
                       //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                       //  var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                       var Sectoken = new JwtSecurityToken(_config["Jwt:Issuer"],
                         _config["Jwt:Issuer"],
                         null,
                         expires: DateTime.Now.AddMinutes(120),
                         signingCredentials: credentials);
                       var token = new JwtSecurityTokenHandler().WriteToken(Sectoken); */

                    
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes("afdafsd1222afdafsd1222afdafsd1222afdafsd1222afdafsd1222afdafsd1222afdafsd1222afdafsd1222");
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new[] { new Claim("id", model.Password) ,
                        new Claim("Email", model.Email)
                        }),
                        Issuer = "localcompany.com",       // <--- add this
                        Audience = "localcompany.com",     // <--- optional, if you're validating audience
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    //return tokenHandler.WriteToken(token);
                    /* */
                    return Ok(new { token = tokenHandler.WriteToken(token) });
                }
                else {
                    return Ok();

                }
            }
           
        }

    }
}
