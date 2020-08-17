
using raul.Models.Db;
using RaulWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Controllers
{
    public class GameController : RaulController
    {

        public GameService gameService;

        public GameController (RaulDbContext context) : base (context)
        {
            this.gameService = new GameService();
        }
    }
}
