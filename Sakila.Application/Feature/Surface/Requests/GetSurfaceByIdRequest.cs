using MediatR;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Dtos.Surfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Application.Feature.Actor.Requests
{
    public class GetSurfaceByIdRequest: IRequest<List<SurfaceDto>>
    {
        public int id { get; set; }
    }
}
