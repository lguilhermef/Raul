using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Team
    {
        public Team()
        {
            GameAwayTeam = new HashSet<Game>();
            GameHomeTeam = new HashSet<Game>();
            Goal = new HashSet<Goal>();
            Player = new HashSet<Player>();
            RaulUserFavTeam = new HashSet<RaulUser>();
            RaulUserMediaFavTeam = new HashSet<RaulUser>();
            RaulUserMediaRivalTeam = new HashSet<RaulUser>();
            RaulUserRivalTeam = new HashSet<RaulUser>();
            RaulUserRlFavteam = new HashSet<RaulUser>();
        }

        public int Id { get; set; }
        public string NvcOfficialName { get; set; }
        public string NvcAlias { get; set; }
        public string NvcInitials { get; set; }
        public bool BitNationalTeam { get; set; }

        public ICollection<Game> GameAwayTeam { get; set; }
        public ICollection<Game> GameHomeTeam { get; set; }
        public ICollection<Goal> Goal { get; set; }
        public ICollection<Player> Player { get; set; }
        public ICollection<RaulUser> RaulUserFavTeam { get; set; }
        public ICollection<RaulUser> RaulUserMediaFavTeam { get; set; }
        public ICollection<RaulUser> RaulUserMediaRivalTeam { get; set; }
        public ICollection<RaulUser> RaulUserRivalTeam { get; set; }
        public ICollection<RaulUser> RaulUserRlFavteam { get; set; }
    }
}
