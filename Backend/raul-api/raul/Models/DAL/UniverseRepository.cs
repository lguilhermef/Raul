using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Models.DAL
{
    public class UniverseRepository : GenericRepository
    {
        private RaulDbContext dbContext;

        public UniverseRepository ()
        {
            this.dbContext = new RaulDbContext();
        }

        public Universe getUniverseById (int id)
        {
            return dbContext.Universe.FirstOrDefault(u => u.Id == id);
        }
    }
}
