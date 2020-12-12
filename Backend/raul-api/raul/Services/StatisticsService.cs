using raul.Models.DAL;
using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Services
{
    public class StatisticsService : GenericService
    {
        private GameRepository _gameRepository;
        private CompetitionRepository _competitionRepository;
       
        public StatisticsService ()
        {
            //This process of constantly instantiating GameRepository() and other controllers or repos..., needs some bootstraping DP
            this._gameRepository = new GameRepository();
            this._competitionRepository = new CompetitionRepository();
        }

        public Dictionary<string, int?> getComptGoalsPerPlayer(int universeId, string competitionName, int competitionEdition)
        {
            //GameRepos should implmenet an interface that olbies implementing these methods where we have cross dependencies
            //Such as a StatisticService having a GameRepository dependency, instead of just StatisticRepository dependency.
            //In fact, it shold happen accross the entire API to avoid interlayer dependencies
            List<Game> lstGame = this._gameRepository.getCompetitionGames(universeId, competitionName, competitionEdition);
            Dictionary<string, int?> usernameGoals = new Dictionary<string, int?>();

            foreach (Game g in lstGame)
            {
                int? outValue;
                //Boilerplate if... make a method ASAP
                if (!usernameGoals.TryGetValue(g.HomeRaulUUsername, out outValue)) 
                {
                    usernameGoals.Add(g.HomeRaulUUsername, 0);
                }

                if (!usernameGoals.TryGetValue(g.AwayRaulUUsername, out outValue))
                {
                    usernameGoals.Add(g.AwayRaulUUsername, 0);
                }

                usernameGoals[g.HomeRaulUUsername] += g.HomeScore != null ? g.HomeScore : 0;
                usernameGoals[g.AwayRaulUUsername] += g.AwayScore != null ? g.AwayScore : 0;
            }

            return usernameGoals;
        }

        public Dictionary<string, int?> getComptWinsPerPlayer(int universeId, string competitionName, int competitionEdition)
        {
            //TODO: Should get the competition Rules and make queries based on that...
            List<Game> lstGame = this._gameRepository.getCompetitionGames(universeId, competitionName, competitionEdition);
            Dictionary<string, int?> usernameWins = new Dictionary<string, int?>();

            foreach (Game g in lstGame)
            {

                int? outValue;
                //Boilerplate if... make a method ASAP -> User exists? If not, add with 0 wins so far.
                if (!usernameWins.TryGetValue(g.HomeRaulUUsername, out outValue))
                {
                    usernameWins.Add(g.HomeRaulUUsername, 0);
                }

                if (!usernameWins.TryGetValue(g.AwayRaulUUsername, out outValue))
                {
                    usernameWins.Add(g.AwayRaulUUsername, 0);
                }

                usernameWins[g.HomeRaulUUsername] += g.HomeScore > g.AwayScore ? 1 : 0;
                usernameWins[g.AwayRaulUUsername] += g.AwayScore > g.HomeScore ? 1 : 0;
            }

            return usernameWins;
        }

    }
}
