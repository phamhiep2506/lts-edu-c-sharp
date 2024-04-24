using AutoMapper;
using wa.Models;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Services;

namespace wa.Profiles;

public class ChiTietHoaDonProfile : Profile
{
    public ChiTietHoaDonProfile()
    {
        CreateMap<CreateChiTietHoaDonDto, ChiTietHoaDon>();
        CreateMap<ChiTietHoaDon, GetChiTietHoaDonDto>();
        CreateMap<CreateChiTietHoaDonDto, GetChiTietHoaDonDto>();
    }
}
