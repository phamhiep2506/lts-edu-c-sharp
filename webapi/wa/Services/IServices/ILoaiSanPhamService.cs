using wa.Models.Dtos.LoaiSanPham;

namespace wa.Services.IServices;

public interface ILoaiSanPhamService
{
    public GetLoaiSanPhamDto CreateLoaiSanPham(CreateLoaiSanPhamDto createLoaiSanPhamDto);
}
