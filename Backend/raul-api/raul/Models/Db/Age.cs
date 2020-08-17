using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Age
    {
        public int Id { get; set; }
        public string CsvPesVersion { get; set; }
        public string NvcName { get; set; }
        public string NvcMediaDescription { get; set; }
        public string CsvSeason { get; set; }
        public int? BallonDeOrWinnerId { get; set; }

        public RaulUser BallonDeOrWinner { get; set; }
    }
}
