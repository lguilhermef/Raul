using raul.Models.DAL;
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
        private GameRepository _gameRepository;

        public GameService ()
        {
            this._gameRepository = new GameRepository();
        }

       // public Game getNextGame (Competition competition)
        //{
            //Game nextGame = this.dbContext.Game.FirstOrDefault(c => c.CompetitionName == competition.ComptName && c.IsOver == true);
       //     return new Game();
       // }

        public Game getNextGame(int universeId, string competitionName, int competitionEdition)
        {
            return _gameRepository.getNextGame(universeId, competitionName, competitionEdition);
        }

        public void persistGame (Game game)
        {
            //dbContext.Game.Add(game);
        }
    }
}
