using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Models.Dtos.HoaDon;

namespace wa.Services.IServices;

public interface IChiTietHoaDonService
{
    public ResponseDto<GetHoaDonDto> AddChiTietHoaDon(
        int hoaDonId,
        List<AddChiTietHoaDonDto> addChiTietHoaDonDtos
    );
    public ResponseDto<GetHoaDonDto> UpdateChiTietHoaDon(
        int hoaDonId,
        UpdateChiTietHoaDonDto updateChiTietHoaDonDto
    );

    public int DeleteChiTietHoaDon(int hoaDonId);
}
