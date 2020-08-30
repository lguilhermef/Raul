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
                .OrderBy(g => g.Id).ToList();
        }

        public void populate()
        {
            dbContext.Game.Add(new Game()
            {
                UniverseId = 1,
                CompetitionName = "League",
                CompetitionEdition = 1,
                CompetitionRound = 1,
                HomeRaulUUsername = "Luís",
                HomeTeam = "",
                HomeScore = null,
                AwayRaulUUsername = "António",
                AwayTeam = "",
                AwayScore = null,
                IsOver = false,
                PlayedDate = null
            });
        }
    }
}
