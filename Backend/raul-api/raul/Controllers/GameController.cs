
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using raul.Models.Db;
using RaulWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Controllers
{
    [Route("api/game/")]
    [ApiController]
    public class GameController : ControllerBase
    {

        public GameService gameService;

        public GameController ()
        {
            this.gameService = new GameService();
        }

        [HttpPost("nextGame")]
        public IActionResult getNextGame([FromBody] JObject competitionIdentifier)
        {
            dynamic json = competitionIdentifier;
            int universeId = json.universeId;
            string competitionName = json.competitionName;
            int competitionEdition = json.competitionEdition;

            //It would be interesting to pass a competitionIdentifier as an argument instead of several different args. Each entity has a Primary Key that could be represented this way.
            Game nextGame = gameService.getNextGame(universeId, competitionName, competitionEdition);

            return Ok(nextGame);
        }

        [HttpGet("currentGameList")]
        public IActionResult getCurrentCompetitionGamesLst()
        {
            List<Game> currentGameLst = new List<Game>();
            return Ok(currentGameLst);
        }
    }
}
