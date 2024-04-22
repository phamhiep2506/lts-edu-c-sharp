using wa.Models.Dtos.KhachHang;

namespace wa.Services.IServices;

public interface IKhachHangService
{
    public GetKhachHangDto CreateKhachHang(CreateKhachHangDto createKhachHangDto);
}
