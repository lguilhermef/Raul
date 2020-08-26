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
        public IActionResult login ([FromBody] JObject authData)
        {
            var json = JsonConvert.SerializeObject(authData);
            return BadRequest();
        }
    }
}
