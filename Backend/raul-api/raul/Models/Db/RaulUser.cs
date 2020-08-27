using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class RaulUser
    {
        public RaulUser()
        {
            Age = new HashSet<Age>();
            Award = new HashSet<Award>();
            Competition = new HashSet<Competition>();
            GameAwayRaulUUsernameNavigation = new HashSet<Game>();
            GameHomeRaulUUsernameNavigation = new HashSet<Game>();
            Goal = new HashSet<Goal>();
            Season = new HashSet<Season>();
        }

        public string Username { get; set; }
        public string RlFavTeam { get; set; }
        public string PesFavTeam { get; set; }
        public string RivalTeam { get; set; }
        public string MediaFavTeam { get; set; }
        public string MediaRivalTeam { get; set; }
        public int? FavPlayerId { get; set; }
        public string Password { get; set; }

        public Player FavPlayer { get; set; }
        public Team MediaFavTeamNavigation { get; set; }
        public Team MediaRivalTeamNavigation { get; set; }
        public Team PesFavTeamNavigation { get; set; }
        public Team RivalTeamNavigation { get; set; }
        public Team RlFavTeamNavigation { get; set; }
        public ICollection<Age> Age { get; set; }
        public ICollection<Award> Award { get; set; }
        public ICollection<Competition> Competition { get; set; }
        public ICollection<Game> GameAwayRaulUUsernameNavigation { get; set; }
        public ICollection<Game> GameHomeRaulUUsernameNavigation { get; set; }
        public ICollection<Goal> Goal { get; set; }
        public ICollection<Season> Season { get; set; }
    }
}
