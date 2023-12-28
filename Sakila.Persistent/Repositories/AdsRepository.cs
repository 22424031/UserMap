using Microsoft.EntityFrameworkCore;
using Sakila.Persistent;
using Sakila.Persistent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ads;
using UserMap.Application.Dtos.SubWard;
using UserMap.Domain;

namespace UserMap.Persistent.Repositories
{
    public class AdsRepository : GenericRepository<Ads>, IAdsRepository
    {
        private readonly UserMapContext _dbcontext;
        public AdsRepository(UserMapContext dbContext) : base(dbContext)
        {
            this._dbcontext = dbContext;
        }
        public async Task SaveChange()
        {
            await _dbcontext.SaveChangeAsync("system");
        }
        public async Task<Ads> GetAdsById(int id)
        {
            return await _dbcontext.Ads.FirstOrDefaultAsync(x => x.AdsID == id);
        }
    }
}
