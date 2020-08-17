﻿using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Competition
    {
        public int Id { get; set; }
        public string NvcName { get; set; }
        public string NvcDescription { get; set; }
        public int RulesId { get; set; }
        public string CsvGame { get; set; }
        public string CsvAward { get; set; }
        public int? WinnerId { get; set; }
        public int Edition { get; set; }
        public int ValueForSeason { get; set; }

        public RaulUser Winner { get; set; }
    }
}
