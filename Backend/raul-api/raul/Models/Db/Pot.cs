using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Pot
    {
        public Pot()
        {
            Game = new HashSet<Game>();
        }

        public string PotName { get; set; }
        public int UniverseId { get; set; }
        public string PotDescription { get; set; }
        public string MediaDescription { get; set; }
        public bool? IsOfficialPot { get; set; }

        public Universe Universe { get; set; }
        public ICollection<Game> Game { get; set; }
    }
}
