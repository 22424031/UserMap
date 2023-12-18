using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Sakila.Application.Dtos.Spaces;
using Sakila.Application.Dtos.Surfaces;

namespace Sakila.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Spaces, SpaceDto>().ReverseMap();
            CreateMap<Domain.Surfaces, SurfaceDto>().ReverseMap();

            //CreateMap<Domain.Surfaces, Dtos.Citys.CityDto>().ReverseMap();
        }
    }
}
