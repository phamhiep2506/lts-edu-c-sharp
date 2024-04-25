using AutoMapper;
using wa.Models;
using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Services.IServices;

namespace wa.Services;

public class ChiTietHoaDonService : IChiTietHoaDonService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public ChiTietHoaDonService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public ResponseDto<GetChiTietHoaDonDto> CreateChiTietHoaDon(
        int hoaDonId,
        List<UpdateChiTietHoaDonDto> updateChiTietHoaDons
    )
    {
        return new ResponseDto<GetChiTietHoaDonDto>();
    }
}
