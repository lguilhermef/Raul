using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using raul.Models.Db;

namespace RaulWebApi.Models
{
    public class League : Competition
    {
        private RaulDbContext dbContext;

        public League ()
        {
            NvcName = "League";
            NvcDescription = "The most important competition of the Season.";
            RulesId = 1;
        }

        public List<Game> generateCalendar ()
        {
            
        }
        
        public void getCurrentCalendar ()
        {

            List<Game> currentCalendar = isCurrentLeagueOver() ? getCurrentCalendarFromDb() : generateCalendar();
            /*if (isCurrentLeagueOver())
            {
                List<Game> currentCalendar = generateCalendar();
            }*/
        }

        public List<Game> getCurrentCalendarFromDb()
        {
            String csvCurrentLeagueGames = dbContext.Competition.OrderBy(c => c.Edition).Where(c => c.NvcName == "League").FirstOrDefault().CsvGame;
            List<Game> currentCalendar = dbContext.Game
        }

        public bool isCurrentLeagueOver()
        {
            Competition currentLeague = dbContext.Competition.OrderBy(c => c.Edition).Where(c=> c.NvcName == "League").FirstOrDefault();

            if (currentLeague == null)
            {
                return true;
            }

            return currentLeague.WinnerId != null;
        }
    }
}
