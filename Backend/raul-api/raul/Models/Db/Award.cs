using System;
using System.Collections.Generic;

namespace raul.Models.Db
{
    public partial class Award
    {
        public int Id { get; set; }
        public string NvcName { get; set; }
        public string NvcDescription { get; set; }
        public string NvcMediaDescription { get; set; }
        public int? RaulUserWinnerId { get; set; }
    }
}
