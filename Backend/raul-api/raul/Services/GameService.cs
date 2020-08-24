using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Services
{
    public partial class GameService
    {
        private RaulDbContext dbContext;
        
        public GameService (RaulDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Game getNextGame (Competition competition)
        {
            Game nextGame = this.dbContext.Game.FirstOrDefault(c => c.CompetitionName == competition.ComptName && c.IsOver == true);
            return nextGame;
        }

        public void persistGame (Game game)
        {
            dbContext.Game.Add(game);
        }
    }
}
