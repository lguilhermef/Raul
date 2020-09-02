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

        public Universe getUniverseWithoutNav (int id)
        {
            Universe universe = dbContext.Universe.FirstOrDefault(u => u.Id == id);
            universe.UniverseUser = null;
            return universe;
        }

        public List<Universe> getUniverseList (string username)
        {
            List<Universe> universeList = new List<Universe>();

            dbContext.UniverseUser.Where(uu => uu.RaulUsername == username).ToList()
                .ForEach(uu => universeList.Add(getUniverseWithoutNav(uu.UniverseId)));

            return universeList;
        }
    }
}