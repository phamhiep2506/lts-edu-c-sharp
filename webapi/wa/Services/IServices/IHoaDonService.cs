using wa.Models.Dtos;
using wa.Models.Dtos.HoaDon;

namespace wa.Services.IServices;

public interface IHoaDonService
{
    public ResponseDto<GetHoaDonDto> CreateHoaDon(CreateHoaDonDto createHoaDonDto);
}
