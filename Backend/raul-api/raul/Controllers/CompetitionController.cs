
using Microsoft.AspNetCore.Mvc;
using raul.Models.Db;
using raul.Services;
using RaulWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Controllers
{
    [Route("api/competition/")]
    [ApiController]
    public class CompetitionController : RaulController
    {

        public CompetitionService competitionService;

        public CompetitionController(RaulDbContext dbContext) : base(dbContext)
        {
            this.competitionService = new CompetitionService(dbContext);
        }

        [HttpGet("nextCompetition")]
        public IActionResult getNextCompetition()
        {
            Competition nextCompetition = competitionService.getNextCompetition();
            return Ok(nextCompetition);
        }
    }
}
