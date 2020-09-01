using raul.Models.DAL;
using raul.Models.Db;
using raul.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Services
{
    public partial class UniverseService : GenericService
    {
        private UniverseRepository _universeRepository;

        public UniverseService ()
        {
            this._universeRepository = new UniverseRepository();
        }

        public Universe getUniverseById (int id)
        {
            return _universeRepository.getUniverseById(id);
        }

        public List<Universe> getUniverseList (string username)
        {
            return _universeRepository.getUniverseList(username);
        }

    }
}
