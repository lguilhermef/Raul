using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Season
    {
        public int SeasonNumber { get; set; }
        public int Age { get; set; }
        public int UniverseId { get; set; }
        public int PesVersion { get; set; }
        public string SeasonHistory { get; set; }
        public string MediaDescription { get; set; }
        public string PlayerOfTheYearId { get; set; }

        public Age AgeNavigation { get; set; }
        public RaulUser PlayerOfTheYear { get; set; }
    }
}
