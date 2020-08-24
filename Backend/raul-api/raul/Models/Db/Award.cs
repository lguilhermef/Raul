using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Award
    {
        public string AwardName { get; set; }
        public string OfficialDescription { get; set; }
        public string MediaDescription { get; set; }
        public string WinnerRaulUUsername { get; set; }
        public bool IsOfficialAward { get; set; }

        public RaulUser WinnerRaulUUsernameNavigation { get; set; }
    }
}
