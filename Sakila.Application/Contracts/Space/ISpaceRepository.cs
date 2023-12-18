using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Application.Contracts.Actor
{
    public interface ISpaceRepository : IGenericRepository<Domain.Spaces>
    {
        Task SaveChange();
    }
}
