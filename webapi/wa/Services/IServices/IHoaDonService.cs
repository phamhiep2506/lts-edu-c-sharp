using wa.Models;
using wa.Models.Dtos.HoaDon;

namespace wa.Services.IServices;

public interface IHoaDonService
{
    public HoaDon AddHoaDon(AddHoaDonDto addHoaDonDto);
}
