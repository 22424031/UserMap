using Sakila.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Domain;

namespace UserMap.Application.Contracts.Ads
{
    public interface IAdsRepository : IGenericRepository<Ads>
    {
    }
}
