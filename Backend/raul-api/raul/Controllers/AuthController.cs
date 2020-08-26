using Microsoft.AspNetCore.Mvc;
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
        private AuthService authService;

        public AuthController (RaulDbContext dbContext) : base (dbContext)
        {
            this.authService = new AuthService();
        }
    }
}
