using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using raul.Models.Db;

namespace RaulWebApi.Controllers
{
    [Route("api/raulUser/")]
    [ApiController]
    public class RaulUserController : ControllerBase
    {

        public RaulUserController ()
        {
        }


        [HttpGet]
        public ActionResult test ()
        {
            return Ok();
        }
    }
}