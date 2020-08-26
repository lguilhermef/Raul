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
    public class AuthController : RaulController
    {

        public AuthController ()
        {
            setServiceImplementation(new AuthService());
        }


        [HttpPost("login")]
        public IActionResult login ([FromBody] RaulUser user)
        {
            RaulUser raulUser = user;
            return BadRequest();
        }

        [HttpPost("register")]
        public IActionResult register([FromBody] JObject newUser)
        {
            var json = JsonConvert.SerializeObject(newUser);
            return BadRequest();
        }
    }
}
