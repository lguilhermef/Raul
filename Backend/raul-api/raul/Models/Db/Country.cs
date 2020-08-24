using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Country
    {
        public Country()
        {
            Team = new HashSet<Team>();
        }

        public string CountryName { get; set; }

        public ICollection<Team> Team { get; set; }
    }
}
