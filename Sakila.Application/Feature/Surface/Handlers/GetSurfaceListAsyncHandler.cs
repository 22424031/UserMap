using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Sakila.Application.Contracts.Actor;
using Sakila.Application.Contracts.Citys;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Feature.Actor.Requests;

namespace Sakila.Application.Feature.Actor.Handlers
{
    public class GetSurfaceListAsyncHandler : IRequestHandler<GetSurfaceListAsyncRequest, IReadOnlyList<Dtos.Surfaces.SurfaceDto>>
    {
        private readonly ISurfaceRepository _spaceRepository;
        private readonly IMapper _mapper;

        public GetSurfaceListAsyncHandler(ISurfaceRepository surfaceRepository, IMapper mapper)
        {
            _spaceRepository = surfaceRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Dtos.Surfaces.SurfaceDto>> Handle(GetSurfaceListAsyncRequest request, CancellationToken cancellationToken)
        {
            var spaces = await _spaceRepository.GetAll();
            return _mapper.Map<IReadOnlyList<Dtos.Surfaces.SurfaceDto>> (spaces);
        }
    }
}
