using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Services
{
    public class CompetitionService
    {
        private RaulDbContext dbContext;

        public CompetitionService(RaulDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Competition getNextCompetition()
        {
            Competition nextCompetition = this.dbContext.Competition.FirstOrDefault();
            return nextCompetition;
        }

        public Competition createNewLeague ()
        {
            Competition newLeague = new Competition();
            return newLeague;
        }
    }
}
