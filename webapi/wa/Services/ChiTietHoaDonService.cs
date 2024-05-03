using AutoMapper;
using wa.Models;
using wa.Models.Dtos;
using wa.Models.Dtos.ChiTietHoaDon;
using wa.Models.Dtos.HoaDon;
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

    public ResponseDto<GetHoaDonDto> AddChiTietHoaDon(
        int hoaDonId,
        List<AddChiTietHoaDonDto> addChiTietHoaDonDtos
    )
    {
        HoaDon? hoaDon = _context
            .HoaDons?.Where(hd => hd.HoaDonId == hoaDonId)
            .SingleOrDefault();

        if (hoaDon == null)
        {
            return new ResponseDto<GetHoaDonDto>()
            {
                status = "error",
                message = "Hóa đơn không tồn tại"
            };
        }

        List<ChiTietHoaDon>? chiTietHoaDons = _context
            .ChiTietHoaDons?.Where(cthd => cthd.HoaDonId == hoaDon.HoaDonId)
            .ToList();

        addChiTietHoaDonDtos.ForEach(cthd =>
        {
            ChiTietHoaDon chiTietHoaDon = _mapper.Map<
                AddChiTietHoaDonDto,
                ChiTietHoaDon
            >(cthd);
            hoaDon.ChiTietHoaDons?.Add(chiTietHoaDon);
        });

        KhachHang? khachHang = _context
            .KhachHangs?.Where(kh => kh.KhachHangId == hoaDon.KhachHangId)
            .SingleOrDefault();

        GetHoaDonDto getHoaDonDto = _mapper.Map<HoaDon, GetHoaDonDto>(hoaDon);
        getHoaDonDto.TenKhachHang = khachHang?.HoTen;
        getHoaDonDto.SoDienThoai = khachHang?.SoDienThoai;

        return new ResponseDto<GetHoaDonDto>()
        {
            status = "success",
            message = "Thêm chi tiết hóa đơn thành công",
            items = new List<GetHoaDonDto>() { getHoaDonDto }
        };
    }
}
