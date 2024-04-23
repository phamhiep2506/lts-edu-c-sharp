using AutoMapper;
using wa.Models;
using wa.Models.Dtos.HoaDon;

namespace wa.Profiles;

public class HoaDonProfile : Profile
{
    public HoaDonProfile()
    {
        CreateMap<HoaDon, AddHoaDonDto>()
            .ForMember(dest => dest.TenHoaDon, source => source.MapFrom(s => s.TenHoaDon))
            .ForMember(dest => dest.GhiChu, source => source.MapFrom(s => s.GhiChu))
            .ReverseMap();
    }
}
