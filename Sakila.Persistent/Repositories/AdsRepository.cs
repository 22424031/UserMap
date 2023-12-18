using Sakila.Persistent;
using Sakila.Persistent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Application.Contracts.Ads;
using UserMap.Domain;

namespace UserMap.Persistent.Repositories
{
    public class AdsRepository : GenericRepository<Ads>, IAdsRepository
    {
        public AdsRepository(UserMapContext dbContext) : base(dbContext)
        {
        }
    }
}
