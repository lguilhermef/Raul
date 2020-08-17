using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class RaulUser
    {
        public RaulUser()
        {
            Age = new HashSet<Age>();
            Competition = new HashSet<Competition>();
            GameAwayRaulUser = new HashSet<Game>();
            GameHomeRaulUser = new HashSet<Game>();
            Goal = new HashSet<Goal>();
            Season = new HashSet<Season>();
        }

        public int Id { get; set; }
        public string NvcUsername { get; set; }
        public int? RlFavteamId { get; set; }
        public int? FavTeamId { get; set; }
        public int? RivalTeamId { get; set; }
        public int? MediaFavTeamId { get; set; }
        public int? MediaRivalTeamId { get; set; }
        public int? RlFavPlayerId { get; set; }

        public Team FavTeam { get; set; }
        public Team MediaFavTeam { get; set; }
        public Team MediaRivalTeam { get; set; }
        public Team RivalTeam { get; set; }
        public Player RlFavPlayer { get; set; }
        public Team RlFavteam { get; set; }
        public ICollection<Age> Age { get; set; }
        public ICollection<Competition> Competition { get; set; }
        public ICollection<Game> GameAwayRaulUser { get; set; }
        public ICollection<Game> GameHomeRaulUser { get; set; }
        public ICollection<Goal> Goal { get; set; }
        public ICollection<Season> Season { get; set; }
    }
}
