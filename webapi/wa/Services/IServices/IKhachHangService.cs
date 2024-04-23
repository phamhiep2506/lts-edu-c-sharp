using wa.Models.Dtos;
using wa.Models.Dtos.KhachHang;

namespace wa.Services.IServices;

public interface IKhachHangService
{
    public ResponseDto<GetKhachHangDto> CreateKhachHang(CreateKhachHangDto createKhachHangDto);
    public int GetKhachHangId(GetKhachHangDto getKhachHangDto);
}
