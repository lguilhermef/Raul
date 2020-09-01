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
    public class UniverseController : ControllerBase
    {

        public UniverseService universeService;

        public UniverseController()
        {
            this.universeService = new UniverseService();
        }

        [HttpPost("universeList")]
        public IActionResult getUniverseList([FromBody] RaulUser user)
        {
            List<Universe> universeLst = universeService.getUniverseList(user.Username);
            return Ok(universeLst);
        }
    }
}
