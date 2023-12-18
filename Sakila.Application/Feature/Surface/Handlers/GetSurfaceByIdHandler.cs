using AutoMapper;
using MediatR;
using Sakila.Application.Contracts.Actor;
using Sakila.Application.Contracts.Citys;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Dtos.Surfaces;
using Sakila.Application.Feature.Actor.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Application.Feature.Actor.Handlers
{
    public class GetSurfaceByIdHandler : IRequestHandler<GetSurfaceByIdRequest,List< SurfaceDto>>
    {
        private readonly ISurfaceRepository _spaceRepository;
        private readonly IMapper _mapper;
        public GetSurfaceByIdHandler(ISurfaceRepository spaceRepository, IMapper mapper)
        {
            _spaceRepository = spaceRepository;
            _mapper = mapper;
        }
        public async Task<List<SurfaceDto>> Handle(GetSurfaceByIdRequest request, CancellationToken cancellationToken)
        {
            var actor = await _spaceRepository.GetListBySpaceID(request.id);
            return _mapper.Map<List<SurfaceDto>>(actor);
        }
    }
}
