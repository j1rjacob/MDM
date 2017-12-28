using AutoMapper;
using DMS.API.Core.Dtos;
using DMS.API.Core.Models;

namespace DMS.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<City, CityDto>();
            CreateMap<Meter, MeterDto>();
        }
    }
}