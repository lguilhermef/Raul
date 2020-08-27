
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("nextGame")]
        public IActionResult getNextGame ()
        {
            Competition competition = new Competition();
            return Ok(gameService.getNextGame(competition));
        }

        [HttpGet("currentGameList")]
        public IActionResult getCurrentCompetitionGamesLst()
        {
            List<Game> currentGameLst = new List<Game>();
            return Ok(currentGameLst);
        }
    }
}
