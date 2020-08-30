using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Player
    {
        public Player()
        {
            RaulUser = new HashSet<RaulUser>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string TeamName { get; set; }

        public Team TeamNameNavigation { get; set; }
        public ICollection<RaulUser> RaulUser { get; set; }
    }
}
