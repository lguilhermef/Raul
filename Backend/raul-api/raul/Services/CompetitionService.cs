using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Services
{
    public class CompetitionService : GenericService
    {

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

        public List<Game> getCalendar (Competition competition)
        {
            //List<Game> calendar = dbContext.Game.ToList();
            return new List<Game>();
        }
    }
}
