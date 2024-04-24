using wa.Models;
using wa.Models.Dtos.ChiTietHoaDon;

namespace wa.Services.IServices;

public interface IChiTietHoaDonService
{
    public ChiTietHoaDon CreateChiTietHoaDon(CreateChiTietHoaDonDto createChiTietHoaDonDto);
}
