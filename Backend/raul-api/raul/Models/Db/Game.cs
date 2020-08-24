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
        public int UniverseId { get; set; }
        public string CompetitionName { get; set; }
        public int CompetitionEdition { get; set; }
        public int CompetitionRound { get; set; }
        public string HomeRaulUUsername { get; set; }
        public string HomeTeam { get; set; }
        public int? HomeScore { get; set; }
        public string AwayRaulUUsername { get; set; }
        public string AwayTeam { get; set; }
        public int? AwayScore { get; set; }
        public bool IsOver { get; set; }
        public DateTime? PlayedDate { get; set; }

        public RaulUser AwayRaulUUsernameNavigation { get; set; }
        public Team AwayTeamNavigation { get; set; }
        public Competition Competition { get; set; }
        public RaulUser HomeRaulUUsernameNavigation { get; set; }
        public Team HomeTeamNavigation { get; set; }
        public ICollection<Goal> Goal { get; set; }
    }
}
