using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Models.Db
{
    public partial class Game
    {

        public Game (int homeRaulUserId, Team homeTeam, int awayRaulUserId, Team awayTeam)
        {
            HomeRaulUserId = homeRaulUserId;
            HomeTeam = homeTeam;
            AwayRaulUserId = awayRaulUserId;
            AwayTeam = awayTeam;
        }
    }
}