using Sakila.Application.Contracts.Actor;
using Sakila.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Persistent.Repositories
{
    public class SpacesRepository : GenericRepository<Spaces>, ISpaceRepository
    {
        private readonly SakilaContext _dbcontext;
        public SpacesRepository(SakilaContext dbContext) : base(dbContext)
        {
            this._dbcontext = dbContext;
        }
        public async Task SaveChange()
        {
            await _dbcontext.SaveChangeAsync("system");
        }
    }
}
