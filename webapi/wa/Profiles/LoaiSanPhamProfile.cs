using AutoMapper;
using wa.Models;
using wa.Models.Dtos.LoaiSanPham;

namespace wa.Profiles;

public class LoaiSanPhamProfile : Profile
{
    public LoaiSanPhamProfile()
    {
        CreateMap<CreateLoaiSanPhamDto, LoaiSanPham>();
        CreateMap<LoaiSanPham, GetLoaiSanPhamDto>();
    }
}
