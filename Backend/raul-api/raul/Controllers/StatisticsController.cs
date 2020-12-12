using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using raul.Services;
using RaulWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Controllers
{
    [Route("api/statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private StatisticsService statisticsService;
        public StatisticsController ()
        {
            
            this.statisticsService = new StatisticsService();
        }

        [HttpPost("comptGoalsPerPlayer")]
        public IActionResult getComptGoalsPerPlayer([FromBody] JObject postedData)
        {
            dynamic json = postedData;
            int universeId = json.universeId;
            string competitionName = json.competitionName;
            int competitionEdition = json.competitionEdition;

            //should receive a competiton identifier to replace the 2nd and 3rd args...
            Dictionary<string, int?> usernameGoals = this.statisticsService.getComptGoalsPerPlayer(universeId, competitionName, competitionEdition);

            return Ok(usernameGoals);
        }

        [HttpPost("competitionPlayerStatistics")]
        public IActionResult getCompetitionPlayerStatistics([FromBody] JObject postedData)
        {
            dynamic json = postedData;
            int universeId = json.universeId;
            string competitionName = json.competitionName;
            int competitionEdition = json.competitionEdition;

            Dictionary<string, int?> usernameWins = this.statisticsService.getComptWinsPerPlayer(universeId, competitionName, competitionEdition);

            return Ok(usernameWins);
        }



    }
}
