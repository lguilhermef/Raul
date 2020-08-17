using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Universe
    {
        public int Id { get; set; }
        public string CsvRaulUser { get; set; }
        public string CsvAge { get; set; }
    }
}
