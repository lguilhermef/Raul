using Microsoft.EntityFrameworkCore;
using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Services
{
    public class GenericService
    {
        public RaulDbContext dbContext { get; set; }

        public GenericService()
        {
            this.dbContext = new RaulDbContext();
        }
    }
}
