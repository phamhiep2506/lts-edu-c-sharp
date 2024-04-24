using AutoMapper;
using wa.Helpers;
using wa.Models;
using wa.Models.Dtos.HoaDon;

namespace wa.Profiles;

public class HoaDonProfile : Profile
{
    public HoaDonProfile()
    {
        CreateMap<CreateHoaDonDto, HoaDon>();
        CreateMap<HoaDon, GetHoaDonDto>()
            .ForMember(
                dest => dest.ThoiGianTao,
                source => source.MapFrom(s => DateTimeConvert.dateTimeToString(s.ThoiGianTao))
            );
    }
}
