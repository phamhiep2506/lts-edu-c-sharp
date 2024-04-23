using AutoMapper;
using wa.Models;
using wa.Models.Dtos.HoaDon;

namespace wa.Profiles;

public class HoaDonProfile : Profile
{
    public HoaDonProfile()
    {
        CreateMap<CreateHoaDonDto, HoaDon>();
        CreateMap<HoaDon, GetHoaDonDto>();
    }
}
