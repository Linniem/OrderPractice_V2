using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderPractice_V2.Data;
using OrderPractice_V2.Helpers;
using OrderPractice_V2.Services;
using OrderPractice_V2.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OrderPractice_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private readonly JwtHelper jwt;
        private readonly IUserService userService;

        public JwtController(JwtHelper jwt, IUserService userService)
        {
            this.jwt = jwt;
            this.userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("signin")]
        public async Task<ActionResult<string>> SignIn([FromForm]LoginViewModel login)
        {
            if ( await userService.ValidateUserAsync(login))
            {
                return jwt.GenerateToken(login.Username);
            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpGet("claims")]
        public IActionResult GetClaims()
        {
            return Ok(User.Claims.Select(p => new { p.Type, p.Value }));
        }

        [Authorize]
        [HttpGet("username")]
        public IActionResult GetUserName()
        {
            return Ok(User.Identity.Name);
        }

        [HttpGet("jwtid")]
        public IActionResult GetUniqueId()
        {
            var jti = User.Claims.FirstOrDefault(p => p.Type == "jti");
            return Ok(jti.Value);
        }

    }
}