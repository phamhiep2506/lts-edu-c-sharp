using AutoMapper;
using wa.Models;
using wa.Models.Dtos.KhachHang;

namespace wa.Profiles;

public class KhachHangProfile : Profile
{
    public KhachHangProfile()
    {
        CreateMap<KhachHang, AddKhachHangDto>()
            .ForMember(dest => dest.HoTen, source => source.MapFrom(s => s.HoTen))
            .ForMember(dest => dest.SoDienThoai, source => source.MapFrom(s => s.SoDienThoai)).ReverseMap();
    }
}
