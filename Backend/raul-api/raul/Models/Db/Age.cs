using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Age
    {
        public Age()
        {
            Season = new HashSet<Season>();
        }

        public int Age1 { get; set; }
        public int UniverseId { get; set; }
        public string PesVersion { get; set; }
        public string MediaName { get; set; }
        public string MediaDescription { get; set; }
        public string BallonDeOrWinnerUsername { get; set; }

        public RaulUser BallonDeOrWinnerUsernameNavigation { get; set; }
        public Universe Universe { get; set; }
        public ICollection<Season> Season { get; set; }
    }
}
