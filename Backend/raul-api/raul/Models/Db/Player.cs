using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Player
    {
        public Player()
        {
            GoalAssist = new HashSet<Goal>();
            GoalScorer = new HashSet<Goal>();
            RaulUser = new HashSet<RaulUser>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string TeamName { get; set; }

        public Team TeamNameNavigation { get; set; }
        public ICollection<Goal> GoalAssist { get; set; }
        public ICollection<Goal> GoalScorer { get; set; }
        public ICollection<RaulUser> RaulUser { get; set; }
    }
}
