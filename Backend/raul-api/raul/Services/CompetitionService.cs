using raul.Models.DAL;
using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Services
{
    public class CompetitionService : GenericService
    {
        private CompetitionRepository _competitionRepository;
        private GameRepository _gameRepository;

        public CompetitionService ()
        {
            this._competitionRepository = new CompetitionRepository();
            this._gameRepository = new GameRepository();
        }

        public Competition getNewestCompetition(int universeId, string competitionName)
        {
            return _competitionRepository.getNewestCompetition(universeId, competitionName);
        }

        public Competition getNextCompetition()
        {
            //Competition nextCompetition = dbContext.Competition.FirstOrDefault();
            return new Competition();
        }

        public Competition createNewLeague ()
        {
            Competition newLeague = new Competition();
            return newLeague;
        }

        public List<Game> getCalendar (int universeId, string competitionName)
        {
            Competition currentCompetition = _competitionRepository.getNewestCompetition(universeId, competitionName);
            return _gameRepository.getCompetitionGames(universeId, competitionName, currentCompetition.Edition);
        }

        public List<Competition> getCompetitionList (int universeId)
        {
            return _competitionRepository.getCompetitionList(universeId);
        }
    }
}
