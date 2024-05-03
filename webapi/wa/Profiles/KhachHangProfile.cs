using AutoMapper;
using wa.Helpers;
using wa.Models;
using wa.Models.Dtos.KhachHang;

namespace wa.Profiles;

public class KhachHangProfile : Profile
{
    public KhachHangProfile()
    {
        CreateMap<CreateKhachHangDto, KhachHang>()
            .ForMember(
                dest => dest.NgaySinh,
                source =>
                    source.MapFrom(s =>
                        DateTimeConvert.stringToDateTime(s.NgaySinh)
                    )
            );

        CreateMap<KhachHang, GetKhachHangDto>()
            .ForMember(
                dest => dest.NgaySinh,
                source =>
                    source.MapFrom(s =>
                        DateTimeConvert.dateTimeToString(s.NgaySinh)
                    )
            );
    }
}
