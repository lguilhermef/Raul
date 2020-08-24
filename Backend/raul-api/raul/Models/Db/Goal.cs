using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Goal
    {
        public int Id { get; set; }
        public string ScorerRaulUUsername { get; set; }
        public string Team { get; set; }
        public int ScorerId { get; set; }
        public int AssistId { get; set; }
        public int GameId { get; set; }
        public int GamePart { get; set; }
        public int GoalTime { get; set; }

        public Player Assist { get; set; }
        public Game Game { get; set; }
        public Player Scorer { get; set; }
        public RaulUser ScorerRaulUUsernameNavigation { get; set; }
        public Team TeamNavigation { get; set; }
    }
}
