using wa.Models;
using wa.Models.Dtos.KhachHang;

namespace wa.Services.IServices;

public interface IKhachHangService
{
    public KhachHang AddKhachHang(AddKhachHangDto addKhachHangDto);
}
