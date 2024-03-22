using Business.Abstract;
using Core.DataAccess.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            IDataResult<User> userToLogin = authService.Login(userForLoginDto);
            if (!userToLogin.Success) return BadRequest(userToLogin.Message);

            IDataResult<AccessToken> result = authService.CreateAccessToken(userToLogin.Data);
            if (result.Success) return Ok(result.Data);

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            IResult userExists = authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success) return BadRequest(userExists.Message);

            IDataResult<User> registerResult = authService.Register(userForRegisterDto, userForRegisterDto.Password);
            IDataResult<AccessToken> result = authService.CreateAccessToken(registerResult.Data);
            if (result.Success) return Ok(result.Data);

            return BadRequest(result.Message);
        }
    }
}