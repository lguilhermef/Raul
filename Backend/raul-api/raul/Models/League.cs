using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using raul.Models.Db;

namespace RaulWebApi.Models
{
    public class League : Competition
    {

        public League ()
        {
            NvcName = "League";
            NvcDescription = "The most important competition of the Season.";
            NvcRules = "Should refer: Points per victory, number of games, qualifiers or/and regular, pots used, value in points, etc.";

        }

        public void generateCalendar ()
        {
            
        }

    }
}
