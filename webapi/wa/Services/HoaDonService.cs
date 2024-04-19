using AutoMapper;
using wa.Models;
using wa.Models.Dtos.HoaDon;
using wa.Services.IServices;

namespace wa.Services;

public class HoaDonService : IHoaDonService
{
    private readonly IMapper _mapper;
    private readonly CuaHangContext _context;

    public HoaDonService(IMapper mapper, CuaHangContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public HoaDon AddHoaDon(AddHoaDonDto addHoaDonDto)
    {
        HoaDon hoaDon = _mapper.Map<HoaDon>(addHoaDonDto);
        int? totalBillInDay;
        totalBillInDay = _context
            .HoaDons?.Where(x =>
                x.ThoiGianTao.Year == DateTime.Now.Year
                && x.ThoiGianTao.Month == DateTime.Now.Month
                && x.ThoiGianTao.Day == DateTime.Now.Year
            )
            .Count();
        hoaDon.MaGiaoDich = DateTime.Now.ToString("yyyymmdd") + "_" + totalBillInDay;
        hoaDon.ThoiGianTao = DateTime.Now;
        _context.Add(hoaDon);
        _context.SaveChanges();
        return hoaDon;
    }
}
