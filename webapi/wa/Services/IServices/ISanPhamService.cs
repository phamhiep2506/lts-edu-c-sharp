using wa.Models.Dtos;
using wa.Models.Dtos.SanPham;

namespace wa.Services.IServices;

public interface ISanPhamService
{
    public ResponseDto<GetSanPhamDto> CreateSanPham(CreateSanPhamDto createSanPhamDto);
}
