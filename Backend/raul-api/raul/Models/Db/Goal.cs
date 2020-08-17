using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Goal
    {
        public int Id { get; set; }
        public int RaulUserId { get; set; }
        public int TeamId { get; set; }
        public int ScorerId { get; set; }
        public int AssisId { get; set; }
        public int GameId { get; set; }
        public int IntGamePart { get; set; }
        public int IntGoalTime { get; set; }

        public Player Assis { get; set; }
        public Game Game { get; set; }
        public RaulUser RaulUser { get; set; }
        public Player Scorer { get; set; }
        public Team Team { get; set; }
    }
}
