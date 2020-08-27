using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using raul.Models.Db;
using raul.Services;
using RaulWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace raul.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private AuthService authService;

        public AuthController ()
        {
            this.authService = new AuthService();
        }

        [HttpPost("login")]
        public IActionResult login ([FromBody] RaulUser userData)
        {
            RaulUser loggedUser = authService.login(userData.Username, userData.Password);
            
            if (loggedUser == null)
            {
                return BadRequest();
            }
            loggedUser.Password = ""; //FIX THIS WITH DTO?
            return Ok(loggedUser);
        }

        [HttpPost("register")]
        public IActionResult register([FromBody] JObject newUser)
        {
            var json = JsonConvert.SerializeObject(newUser);
            return BadRequest();
        }
    }
}
