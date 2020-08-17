
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
    public class GameController : RaulController
    {

        public GameService gameService;

        public GameController (RaulDbContext dbContext) : base (dbContext)
        {
            this.gameService = new GameService(dbContext);
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
