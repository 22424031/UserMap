using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UserMap.Application.Dtos.Ads;
using UserMap.Domain;

namespace Sakila.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
       

            CreateMap<Ads, AdsDto>().ReverseMap();
        }
    }
}
