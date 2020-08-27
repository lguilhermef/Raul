using raul.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace raul.Models.DAL
{
    public class AuthRepository
    {
        private RaulDbContext dbContext;

        public AuthRepository ()
        {
            this.dbContext = new RaulDbContext();
        }

        public RaulUser getUser(string username)
        {
            return dbContext.RaulUser.Where(u => u.Username == username).FirstOrDefault();
        }
    }
}
