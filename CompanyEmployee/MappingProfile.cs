using AutoMapper;
using Entities.DataTransfereObjects;
using Entities.Models;

namespace CompanyEmployee
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyResponse>()
            .ForMember(dst => dst.FullAdress, opt => opt.MapFrom(src => string.Join(' ', src.Address, src.Country)));
        }

    }
}
