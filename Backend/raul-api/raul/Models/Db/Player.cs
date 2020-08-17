using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Player
    {
        public Player()
        {
            GoalAssis = new HashSet<Goal>();
            GoalScorer = new HashSet<Goal>();
            RaulUser = new HashSet<RaulUser>();
        }

        public int Id { get; set; }
        public string NvcFullName { get; set; }
        public int? TeamId { get; set; }

        public Team Team { get; set; }
        public ICollection<Goal> GoalAssis { get; set; }
        public ICollection<Goal> GoalScorer { get; set; }
        public ICollection<RaulUser> RaulUser { get; set; }
    }
}
