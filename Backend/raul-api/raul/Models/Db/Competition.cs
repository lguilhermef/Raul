using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Competition
    {
        public Competition()
        {
            Game = new HashSet<Game>();
        }

        public int UniverseId { get; set; }
        public string ComptName { get; set; }
        public string Alias { get; set; }
        public string History { get; set; }
        public string Rules { get; set; }
        public string WinnerId { get; set; }
        public int Edition { get; set; }
        public bool IsOfficialCompetition { get; set; }

        public Universe Universe { get; set; }
        public RaulUser Winner { get; set; }
        public ICollection<Game> Game { get; set; }
    }
}
