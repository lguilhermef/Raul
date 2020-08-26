using Microsoft.AspNetCore.Mvc;
using raul.Models.Db;
using RaulWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Controllers
{
    [Route("api/universe")]
    [ApiController]
    public class UniverseController : RaulController
    {

        public UniverseService universeService;

        public UniverseController()
        {

        }
    }
}
