using AutoMapper;
using wa.Models;
using wa.Models.Dtos.ChiTietHoaDon;

namespace wa.Profiles;

public class ChiTietHoaDonProfile : Profile
{
    public ChiTietHoaDonProfile()
    {
        CreateMap<ChiTietHoaDon, AddChiTietHoaDonDto>()
            .ForMember(dest => dest.SoLuong, source => source.MapFrom(s => s.SoLuong))
            .ForMember(dest => dest.DonViTinh, source => source.MapFrom(s => s.DonViTinh));
    }
}
