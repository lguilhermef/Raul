using raul.Models.Db;
using raul.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Services
{
    public partial class GameService : GenericService
    {

        public Game getNextGame (Competition competition)
        {
            //Game nextGame = this.dbContext.Game.FirstOrDefault(c => c.CompetitionName == competition.ComptName && c.IsOver == true);
            return new Game();
        }

        public void persistGame (Game game)
        {
            //dbContext.Game.Add(game);
        }
    }
}
