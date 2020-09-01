
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

        [HttpPost("getNewestCompetition")]
        public IActionResult getNewestCompetition ([FromBody] JObject jsonData)
        {
            dynamic json = jsonData;
            int universeId = json.universeId;
            string competitionName = json.competitionName;

            Competition competition = competitionService.getNewestCompetition(universeId, competitionName);
            return Ok(competition);
        }

        [HttpGet("nextCompetition")]
        public IActionResult getNextCompetition()
        {
            Competition nextCompetition = competitionService.getNextCompetition();
            return Ok(nextCompetition);
        }

        [HttpPost("comptList")]
        public IActionResult getCompetitionList([FromBody] Universe universe)
        {
            List<Competition> comptList = competitionService.getCompetitionList(universe.Id);
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

        [HttpPost("generateCalendar")]
        public IActionResult generateCalendar ([FromBody] JObject jsonData)
        {
            dynamic json = jsonData;
            int universeId = json.universeId;
            string competitionName = json.competitionName;

            List<Game> newCalendar = competitionService.generateCalendar(universeId ,competitionName);
            return Ok(newCalendar);
        }
    }
}
