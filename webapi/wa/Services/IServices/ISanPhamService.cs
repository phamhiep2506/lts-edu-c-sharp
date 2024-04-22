using wa.Models.Dtos.SanPham;

namespace wa.Services.IServices;

public interface ISanPhamService
{
    public GetSanPhamDto CreateSanPham(CreateSanPhamDto createLoaiSanPhamDto);
}
