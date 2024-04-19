using AutoMapper;
using wa.Models;
using wa.Models.Dtos.HoaDon;

namespace wa.Services;

public class HoaDonService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public HoaDonService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public AddHoaDonDto AddHoaDon(AddHoaDonDto addHoaDonDto)
    {
        HoaDon hoaDon = _mapper.Map<HoaDon>(addHoaDonDto);
        return addHoaDonDto;
    }
}
