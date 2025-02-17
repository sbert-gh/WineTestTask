using AutoMapper;

namespace WineCatalog.Core.Models
{
    public class WineMappingProfile : Profile
    {
        public WineMappingProfile()
        {
            CreateMap<Wine, WineDto>().ReverseMap();
        }
    }
}
