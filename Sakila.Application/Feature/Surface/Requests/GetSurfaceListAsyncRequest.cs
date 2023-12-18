using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Sakila.Application.Dtos.Spaces;
using Sakila.Domain;

namespace Sakila.Application.Feature.Actor.Requests
{
    public class GetSurfaceListAsyncRequest : IRequest<IReadOnlyList<Dtos.Surfaces.SurfaceDto>>
    {
        
    }
}
