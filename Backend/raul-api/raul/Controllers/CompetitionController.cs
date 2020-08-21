
using Microsoft.AspNetCore.Cors;
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

        [HttpGet("comptList")]
        public IActionResult getCompetitionList()
        {
            List<String> comptList = new List<String>();
            comptList.Add("League");
            comptList.Add("Cup");
            comptList.Add("Super Cup");
            comptList.Add("League Cup");
            comptList.Add("Champions League");
            comptList.Add("Intertoto");

            return Ok(comptList);
        }
    }
}
