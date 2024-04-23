using AutoMapper;
using wa.Models;
using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Models.Dtos.HoaDon;
using wa.Models.Dtos.KhachHang;
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

    public ResponseDto<GetHoaDonDto> CreateHoaDon(CreateHoaDonDto createHoaDonDto)
    {
        if (
            createHoaDonDto.TenKhachHang == null
            || createHoaDonDto.SoDienThoai == null
            || createHoaDonDto.TenHoaDon == null
            || createHoaDonDto.CreateChiTietHoaDons == null
        )
        {
            return new ResponseDto<GetHoaDonDto>() { status = "error", message = "Not params" };
        }

        HoaDon hoaDon = _mapper.Map<CreateHoaDonDto, HoaDon>(createHoaDonDto);
        List<ChiTietHoaDon> chiTietHoaDons = _mapper.Map<
            List<CreateChiTietHoaDonDto>?,
            List<ChiTietHoaDon>
        >(createHoaDonDto.CreateChiTietHoaDons);

        int khachHangId = new KhachHangService(_mapper, _context).GetKhachHangId(
            new GetKhachHangDto()
            {
                HoTen = createHoaDonDto.TenKhachHang,
                SoDienThoai = createHoaDonDto.SoDienThoai
            }
        );
        if (khachHangId == -1)
        {
            return new ResponseDto<GetHoaDonDto>()
            {
                status = "error",
                message = "Không thể tìm kiếm khách hàng id"
            };
        }
        hoaDon.KhachHangId = (int)khachHangId;

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
        if (totalBillInDay == null)
        {
            hoaDon.MaGiaoDich =
                DateTime.Now.ToString("yyyyMMdd") + "_" + (0).ToString().PadLeft(3, '0');
        }
        hoaDon.MaGiaoDich =
            DateTime.Now.ToString("yyyyMMdd")
            + "_"
            + (totalBillInDay + 1).ToString()?.PadLeft(3, '0');

        hoaDon.ThoiGianTao = DateTime.Now;

        _context.Add(hoaDon);
        _context.SaveChanges();
    }
}
