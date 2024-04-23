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

        int? totalBillInDay = _context
            .HoaDons?.Where(x =>
                x.ThoiGianTao.Year == DateTime.Now.Year
                && x.ThoiGianTao.Month == DateTime.Now.Month
                && x.ThoiGianTao.Day == DateTime.Now.Day
            )
            .GroupBy(x => x.KhachHangId)
            .Select(x => new { count = x.Count() })
            .FirstOrDefault()
            ?.count;

        int? khachHangId = _context
            .KhachHangs?.Where(x => x.HoTen == addHoaDonDto.TenKhachHang)
            .Select(x => x.KhachHangId)
            .FirstOrDefault();

        if (khachHangId != null)
        {
            hoaDon.KhachHangId = khachHangId.Value;
        }

        if (totalBillInDay != null)
        {
            hoaDon.MaGiaoDich =
                DateTime.Now.ToString("yyyymmdd")
                + "_"
                + (totalBillInDay + 1).ToString()?.PadLeft(3, '0');
        }

        hoaDon.ThoiGianTao = DateTime.Now;
        _context.Add(hoaDon);
        _context.SaveChanges();
        return hoaDon;
    }
}
