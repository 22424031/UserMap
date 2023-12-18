using MediatR;
using Sakila.Application.Dtos.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Application.Feature.Actor.Requests
{
    public class GetSpaceByIdRequest: IRequest<SpaceDto>
    {
        public int id { get; set; }
    }
}
