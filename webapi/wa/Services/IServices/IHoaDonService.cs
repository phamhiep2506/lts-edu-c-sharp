using wa.Models.Dtos;
using wa.Models.Dtos.HoaDon;

namespace wa.Services.IServices;

public interface IHoaDonService
{
    public ResponseDto<GetHoaDonDto> CreateHoaDon(
        CreateHoaDonDto createHoaDonDto
    );

    public ResponseDto<GetHoaDonDto> DeleteHoaDon(int hoaDonId);

    public ResponseDto<GetHoaDonDto> GetHoaDonById(int hoaDonId);

    public ResponseDto<GetHoaDonDto> GetHoaDonByDate(int thang, int nam, int page, int size);

    public ResponseDto<GetHoaDonDto> GetHoaDonByDay(int start, int end, int page, int size);

    public ResponseDto<GetHoaDonDto> GetHoaDonByMoney(int start, int end, int page, int size);

    public ResponseDto<GetHoaDonDto> GetHoaDonByCode(string code);

    public string taoMaGiaoDich();
}
