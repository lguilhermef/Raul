using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Season
    {
        public int Id { get; set; }
        public int IntYear { get; set; }
        public int IntPesVersion { get; set; }
        public string NvcDescription { get; set; }
        public string NvcMediaDescription { get; set; }
        public string CsvCompetition { get; set; }
        public string CsvAward { get; set; }
        public int? PlayerOfTheYearWinnerId { get; set; }

        public RaulUser PlayerOfTheYearWinner { get; set; }
    }
}
