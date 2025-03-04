using System.Text;
using DrogeriaProjekt.Models;
using DrogeriaProjekt.Services.Models.Interfaces;
using DrogeriaProjekt.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrogeriaProjekt.Controllers
{
    public class LoginRequest
    {
        public string Credential { get; set; }
        public string Password { get; set; }
    }

    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService UserService;

        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpPost("Login")]
        public async Task<ClientUser> LoginUser([FromBody] LoginRequest request)
        {
            var credential = request.Credential;
            var password = Security.Hash( request.Password, Encoding.ASCII);

            bool credentialsCorrect = await UserService.ValidateCredentialsAsync(credential, password);

            if (!credentialsCorrect)
            {
                return null;
            }

            var userByEmail = await UserService.GetUserByEmailAsync(credential);

            if(userByEmail != null)
            {
                return new(userByEmail);
            }

            return null;
        }

        [HttpPost("Register")]
        public async Task<bool> RegisterUser([FromBody] RegisterRequest request)
        {
            var email = request.Email;
            var password = Security.Hash(request.Password, Encoding.ASCII);

            var user = new User()
            {
                Email = email,
                Password = password,
                Verified = false,
                Admin = false
            };

            return await UserService.AddUserAsync(user);
        }
    }
}
