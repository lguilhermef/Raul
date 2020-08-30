
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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
    public class CompetitionController : ControllerBase
    {

        public CompetitionService competitionService;
        public UniverseService universeService;

        public CompetitionController()
        {
            this.competitionService = new CompetitionService();
            this.universeService = new UniverseService();
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
            comptList.Add("Intercontinental");

            return Ok(comptList);
        }

        [HttpPost("calendar")]
        public IActionResult getCalendar ([FromBody] JObject jsonData)
        {
            dynamic json = jsonData;
            int universeId = json.universeId;
            string competitionName = json.competitionName;
            //TODO: Create a layer to allow declaring postedData type
            
            List<Game> calendarTest = competitionService.getCalendar(universeId, competitionName);
            
            return Ok(calendarTest);
        }
    }
}
