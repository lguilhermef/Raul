using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Models.DAL
{
    public class CompetitionRepository
    {
        private RaulDbContext dbContext;
        public CompetitionRepository()
        {
            this.dbContext = new RaulDbContext();
        }

        public Competition getNewestCompetition(int universeId, string competitionName)
        {
            return dbContext.Competition.OrderBy(c => c.Edition)
                .Where(c => c.UniverseId == universeId && c.ComptName == competitionName).FirstOrDefault();
        }
    }
}
