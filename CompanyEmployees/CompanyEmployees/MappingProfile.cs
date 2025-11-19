using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace CompanyEmployees
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>().ForCtorParam("FullAddress",
                opt => opt.MapFrom(x => string.Concat(x.Address, " ", x.Country)));
        }
    }
}
