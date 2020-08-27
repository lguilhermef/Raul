using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Team
    {
        public Team()
        {
            GameAwayTeamNavigation = new HashSet<Game>();
            GameHomeTeamNavigation = new HashSet<Game>();
            Goal = new HashSet<Goal>();
            Player = new HashSet<Player>();
            RaulUserMediaFavTeamNavigation = new HashSet<RaulUser>();
            RaulUserMediaRivalTeamNavigation = new HashSet<RaulUser>();
            RaulUserPesFavTeamNavigation = new HashSet<RaulUser>();
            RaulUserRivalTeamNavigation = new HashSet<RaulUser>();
            RaulUserRlFavTeamNavigation = new HashSet<RaulUser>();
        }

        public string TeamName { get; set; }
        public string Country { get; set; }
        public string Supporters { get; set; }
        public string Initials { get; set; }
        public bool IsNationalTeam { get; set; }

        public Country CountryNavigation { get; set; }
        public ICollection<Game> GameAwayTeamNavigation { get; set; }
        public ICollection<Game> GameHomeTeamNavigation { get; set; }
        public ICollection<Goal> Goal { get; set; }
        public ICollection<Player> Player { get; set; }
        public ICollection<RaulUser> RaulUserMediaFavTeamNavigation { get; set; }
        public ICollection<RaulUser> RaulUserMediaRivalTeamNavigation { get; set; }
        public ICollection<RaulUser> RaulUserPesFavTeamNavigation { get; set; }
        public ICollection<RaulUser> RaulUserRivalTeamNavigation { get; set; }
        public ICollection<RaulUser> RaulUserRlFavTeamNavigation { get; set; }
    }
}
