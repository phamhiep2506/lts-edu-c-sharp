using wa.Models.Dtos;
using wa.Models.Dtos.LoaiSanPham;

namespace wa.Services.IServices;

public interface ILoaiSanPhamService
{
    public ResponseDto<GetLoaiSanPhamDto> CreateLoaiSanPham(
        CreateLoaiSanPhamDto createLoaiSanPhamDto
    );

    public ResponseDto<GetLoaiSanPhamDto> GetLoaiSanPham();
}
