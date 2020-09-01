using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class UniverseUser
    {
        public int UniverseId { get; set; }
        public string RaulUsername { get; set; }

        public RaulUser RaulUsernameNavigation { get; set; }
        public Universe Universe { get; set; }
    }
}
