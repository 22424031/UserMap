using AutoMapper;
using MediatR;
using Sakila.Application.Contracts.Actor;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Feature.Actor.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakila.Application.Feature.Actor.Handlers
{
    public class GetSpaceByIdHandler : IRequestHandler<GetSpaceByIdRequest, SpaceDto>
    {
        private readonly ISpaceRepository _spaceRepository;
        private readonly IMapper _mapper;
        public GetSpaceByIdHandler(ISpaceRepository spaceRepository, IMapper mapper)
        {
            _spaceRepository = spaceRepository;
            _mapper = mapper;
        }
        public async Task<SpaceDto> Handle(GetSpaceByIdRequest request, CancellationToken cancellationToken)
        {
            var actor = await _spaceRepository.Get(request.id);
            return _mapper.Map<SpaceDto>(actor);
        }
    }
}
