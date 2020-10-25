using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Models.DAL
{
    public class GameRepository
    {
        private RaulDbContext dbContext;
        public GameRepository ()
        {
            this.dbContext = new RaulDbContext();
        }

        public List<Game> getCompetitionGames (int universeId, string competitionName, int competitionEdition)
        {
            return dbContext.Game
                .Where(g => g.UniverseId == universeId && g.CompetitionName == competitionName && g.CompetitionEdition == competitionEdition)
                .OrderBy(g => g.CompetitionRound).ToList();
        }

        //Considering ObjectIdentifiers, a Game could be stored with just one column called Identifier that would result from concatenating universeId, comptName and comptEdition: 3League4;
        public Game getNextGame(int universeId, string competitionName, int competitionEdition)
        {
            return dbContext.Game.Where(g => g.UniverseId == universeId && competitionName == g.CompetitionName && g.CompetitionEdition == competitionEdition && !g.IsOver).FirstOrDefault();
        }
    }
}
