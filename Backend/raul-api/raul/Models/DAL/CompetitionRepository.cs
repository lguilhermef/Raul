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

        //TODO: CompetitionIdentifier here
        public Competition getCompetitionByNameAndEdition(string name, int edition)
        {
            return dbContext.Competition.FirstOrDefault(c => c.ComptName == name && c.Edition == edition);
        }

        public Competition getNewestCompetition(int universeId, string competitionName)
        {
            Competition competition = dbContext.Competition.OrderBy(c => c.Edition)
                .Where(c => c.UniverseId == universeId && c.ComptName == competitionName).FirstOrDefault();
            return competition;
        }

        public List<Competition> getCompetitionList (int universeId)
        {
            return dbContext.Competition.Where(c => c.UniverseId == universeId).ToList();
        }
    }
}
