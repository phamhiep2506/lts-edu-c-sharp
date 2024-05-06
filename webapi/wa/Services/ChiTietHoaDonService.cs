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

        addChiTietHoaDonDtos.ForEach(cthd =>
        {
            ChiTietHoaDon chiTietHoaDon = _mapper.Map<
                AddChiTietHoaDonDto,
                ChiTietHoaDon
            >(cthd);
            chiTietHoaDon.HoaDonId = hoaDon.HoaDonId;
            SanPham? sanPham = _context.SanPhams?.Where(x => x.TenSanPham == cthd.TenSanPham).SingleOrDefault();
            if(sanPham == null)
            {
                return;
            }
            chiTietHoaDon.SanPhamId = sanPham.SanPhamId;
            chiTietHoaDon.ThanhTien = sanPham.GiaThanh * chiTietHoaDon.SoLuong;
            _context.Add(chiTietHoaDon);
            _context.SaveChanges();
        });

        List<ChiTietHoaDon> chiTietHoaDons = _context.ChiTietHoaDons!.Where(x => x.HoaDonId == hoaDonId).ToList();

        double tongTien = 0;
        foreach(ChiTietHoaDon chiTietHoaDon in chiTietHoaDons)
        {
            tongTien = tongTien + chiTietHoaDon.ThanhTien;
        }

        hoaDon.TongTien = tongTien;
        _context.Update(hoaDon);
        _context.SaveChanges();

        KhachHang? khachHang = _context
            .KhachHangs?.Where(kh => kh.KhachHangId == hoaDon.KhachHangId)
            .SingleOrDefault();

        GetHoaDonDto getHoaDonDto = _mapper.Map<HoaDon, GetHoaDonDto>(hoaDon);
        getHoaDonDto.TenKhachHang = khachHang?.HoTen;
        getHoaDonDto.SoDienThoai = khachHang?.SoDienThoai;
        getHoaDonDto.ChiTietHoaDons = _mapper.Map<List<ChiTietHoaDon>, List<GetChiTietHoaDonDto>>(chiTietHoaDons);
        foreach(GetChiTietHoaDonDto chiTietHoaDonDto in getHoaDonDto.ChiTietHoaDons)
        {
            chiTietHoaDonDto.TenSanPham = _context.SanPhams!.Where(x => x.SanPhamId == chiTietHoaDonDto.SanPhamId).Select(x => x.TenSanPham).SingleOrDefault();
        }

        return new ResponseDto<GetHoaDonDto>()
        {
            status = "success",
            message = "Thêm chi tiết hóa đơn thành công",
            items = new List<GetHoaDonDto>() { getHoaDonDto }
        };
    }
}
