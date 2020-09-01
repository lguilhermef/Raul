using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Universe
    {
        public Universe()
        {
            Age = new HashSet<Age>();
            Competition = new HashSet<Competition>();
            Pot = new HashSet<Pot>();
            UniverseUser = new HashSet<UniverseUser>();
        }

        public int Id { get; set; }
        public string History { get; set; }
        public DateTime? CreationDate { get; set; }

        public ICollection<Age> Age { get; set; }
        public ICollection<Competition> Competition { get; set; }
        public ICollection<Pot> Pot { get; set; }
        public ICollection<UniverseUser> UniverseUser { get; set; }
    }
}
