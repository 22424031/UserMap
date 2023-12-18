using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Sakila.Application.Contracts.Actor;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Feature.Actor.Requests;

namespace Sakila.Application.Feature.Actor.Handlers
{
    public class GetSpaceListAsyncHandler : IRequestHandler<GetSpaceListAsyncRequest, IReadOnlyList<Dtos.Spaces.SpaceDto>>
    {
        private readonly ISpaceRepository _spaceRepository;
        private readonly IMapper _mapper;

        public GetSpaceListAsyncHandler(ISpaceRepository actorRepository, IMapper mapper)
        {
            _spaceRepository = actorRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<SpaceDto>> Handle(GetSpaceListAsyncRequest request, CancellationToken cancellationToken)
        {
            var spaces = await _spaceRepository.GetAll();
            return _mapper.Map<IReadOnlyList<SpaceDto>> (spaces);
        }
    }
}
