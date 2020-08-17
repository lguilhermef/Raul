using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Game
    {
        public Game()
        {
            Goal = new HashSet<Goal>();
        }

        public int Id { get; set; }
        public int HomeRaulUserId { get; set; }
        public int HomeTeamId { get; set; }
        public int HomeScore { get; set; }
        public int AwayRaulUserId { get; set; }
        public int AwayTeamId { get; set; }
        public int AwayScore { get; set; }

        public RaulUser AwayRaulUser { get; set; }
        public Team AwayTeam { get; set; }
        public RaulUser HomeRaulUser { get; set; }
        public Team HomeTeam { get; set; }
        public ICollection<Goal> Goal { get; set; }
    }
}
