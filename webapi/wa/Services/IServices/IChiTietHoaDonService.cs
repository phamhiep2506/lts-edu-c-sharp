using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;

namespace wa.Services.IServices;

public interface IChiTietHoaDonService
{
    public ResponseDto<GetChiTietHoaDonDto> CreateChiTietHoaDon(
        int hoaDonId,
        List<UpdateChiTietHoaDonDto> updateChiTietHoaDons
    );
}
