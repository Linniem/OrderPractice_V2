using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderPractice_V2.Helpers;
using OrderPractice_V2.ViewModels;
using OrderPractice_V2.Data;
using Microsoft.EntityFrameworkCore;

namespace OrderPractice_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private readonly JwtHelper jwt;
        private readonly OrderPracticeContext db;

        public JwtController(JwtHelper jwt, OrderPracticeContext db)
        {
            this.jwt = jwt;
            this.db = db;
        }

        [AllowAnonymous]
        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok(1);
        }
        [Authorize]
        [HttpGet("Test2")]
        public IActionResult Test2()
        {
            return Ok(2);
        }

        [AllowAnonymous]
        [HttpPost("signin")]
        public async Task<ActionResult<string>> SignIn([FromForm]LoginViewModel login)
        {
            if ( await ValidateUserAsync(login))
            {
                return jwt.GenerateToken(login.Username);
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<bool> ValidateUserAsync(LoginViewModel login)
        {
            var a = await db.Users.FirstOrDefaultAsync(
                x => x.UserName == login.Username 
                && x.Password == login.Password
                );
            if (a != null)
            {
                return true;
            }
            return false;
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