using AutoMapper;
using wa.Models;
using wa.Models.Dtos.ChiTietHoaDon;

namespace wa.Profiles;

public class ChiTietHoaDonProfile : Profile
{
    public ChiTietHoaDonProfile()
    {
        CreateMap<CreateChiTietHoaDonDto, ChiTietHoaDon>();
        CreateMap<ChiTietHoaDon, GetChiTietHoaDonDto>();
        CreateMap<AddChiTietHoaDonDto, ChiTietHoaDon>();
    }
}
