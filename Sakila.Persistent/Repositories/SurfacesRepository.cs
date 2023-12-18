using Microsoft.EntityFrameworkCore;
using Sakila.Application.Contracts.Citys;
using Sakila.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Persistent.Repositories
{
    public class SurfacesRepository : GenericRepository<Surfaces>, ISurfaceRepository
    {
        private readonly SakilaContext _sakilaContext;
        public SurfacesRepository(SakilaContext dbContext) : base(dbContext)
        {
           _sakilaContext = dbContext;
        }

        public async Task<Surfaces> SearchCity(string cityname)
        {
            Surfaces rs = await _sakilaContext.Surfaces.FirstOrDefaultAsync(x => x.Format == cityname);
            return rs;
        }
        public async Task<List<Surfaces>> GetListBySpaceID(int id)
        {
            var res = await _sakilaContext.Surfaces.Where(x => x.Spaces == id).ToListAsync();
            return res;
        }
    }
}
