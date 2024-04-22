using AutoMapper;
using wa.Models;
using wa.Models.Dtos.SanPham;

namespace wa.Profiles;

public class SanPhamProfile : Profile
{
    public SanPhamProfile()
    {
        CreateMap<CreateSanPhamDto, SanPham>();
        CreateMap<SanPham, GetSanPhamDto>();
    }
}
