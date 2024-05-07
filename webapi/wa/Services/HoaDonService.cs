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

    public ResponseDto<GetHoaDonDto> CreateHoaDon(
        CreateHoaDonDto createHoaDonDto
    )
    {
        if (
            createHoaDonDto.TenKhachHang == null
            || createHoaDonDto.SoDienThoai == null
            || createHoaDonDto.TenHoaDon == null
            || createHoaDonDto.ChiTietHoaDons == null
        )
        {
            return new ResponseDto<GetHoaDonDto>()
            {
                status = "error",
                message = "Not params"
            };
        }

        foreach (
            CreateChiTietHoaDonDto createChiTietHoaDonDto in createHoaDonDto.ChiTietHoaDons
        )
        {
            bool? isTenSanPham = _context.SanPhams?.Any(x =>
                x.TenSanPham == createChiTietHoaDonDto.TenSanPham
            );
            if (isTenSanPham == false || isTenSanPham == null)
            {
                return new ResponseDto<GetHoaDonDto>()
                {
                    status = "error",
                    message = "Không thể tìm kiếm sản phẩm id"
                };
            }
        }

        foreach (
            CreateChiTietHoaDonDto createChiTietHoaDonDto in createHoaDonDto.ChiTietHoaDons
        )
        {
            int sanPhamId = new SanPhamService(
                _mapper,
                _context
            ).GetSanPhamIdByName(createChiTietHoaDonDto.TenSanPham!);
            createChiTietHoaDonDto.SanPhamId = sanPhamId;
        }

        HoaDon hoaDon = _mapper.Map<CreateHoaDonDto, HoaDon>(createHoaDonDto);

        foreach (ChiTietHoaDon chiTietHoaDon in hoaDon.ChiTietHoaDons!)
        {
            double? giaThanh = _context
                .SanPhams?.Where(x => x.SanPhamId == chiTietHoaDon.SanPhamId)
                .Select(x => x.GiaThanh)
                .FirstOrDefault();

            chiTietHoaDon.ThanhTien = chiTietHoaDon.SoLuong * giaThanh ?? 0;
        }
        ;

        int khachHangId = new KhachHangService(
            _mapper,
            _context
        ).GetKhachHangId(
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

        hoaDon.MaGiaoDich = taoMaGiaoDich();

        hoaDon.ThoiGianTao = DateTime.Now;

        double tongTien = 0;
        foreach (ChiTietHoaDon chiTietHoaDon in hoaDon.ChiTietHoaDons!)
        {
            tongTien += chiTietHoaDon.ThanhTien;
        }
        hoaDon.TongTien = tongTien;

        _context.Add(hoaDon);
        _context.SaveChanges();

        GetHoaDonDto getHoaDonDto = _mapper.Map<HoaDon, GetHoaDonDto>(hoaDon);
        getHoaDonDto.TenKhachHang = createHoaDonDto.TenKhachHang;
        getHoaDonDto.SoDienThoai = createHoaDonDto.SoDienThoai;

        for (int i = 0; i < createHoaDonDto.ChiTietHoaDons.Count; i++)
        {
            if (getHoaDonDto.ChiTietHoaDons == null)
            {
                break;
            }
            getHoaDonDto.ChiTietHoaDons[i].TenSanPham = createHoaDonDto
                .ChiTietHoaDons[i]
                .TenSanPham;
        }

        return new ResponseDto<GetHoaDonDto>()
        {
            status = "success",
            message = "Thêm hóa đơn thành công",
            items = new List<GetHoaDonDto>() { getHoaDonDto }
        };
    }

    public ResponseDto<GetHoaDonDto> DeleteHoaDon(int hoaDonId)
    {
        int status = new ChiTietHoaDonService(
            _mapper,
            _context
        ).DeleteChiTietHoaDon(hoaDonId);
        if (status < 0)
        {
            return new ResponseDto<GetHoaDonDto>()
            {
                status = "success",
                message = "Xóa chi tiết hóa đơn thất bại",
            };
        }

        List<HoaDon>? hoaDon = _context
            .HoaDons?.Where(x => x.HoaDonId == hoaDonId)
            .ToList();

        if (hoaDon == null)
        {
            return new ResponseDto<GetHoaDonDto>()
            {
                status = "success",
                message = "Hóa đơn không tồn tại",
            };
        }

        _context.RemoveRange(hoaDon);
        _context.SaveChanges();

        return new ResponseDto<GetHoaDonDto>()
        {
            status = "success",
            message = "Xóa hóa đơn thành công",
        };
    }

    public string taoMaGiaoDich()
    {
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
            return DateTime.Now.ToString("yyyyMMdd")
                + "_"
                + (0).ToString().PadLeft(3, '0');
        }

        return DateTime.Now.ToString("yyyyMMdd")
            + "_"
            + (totalBillInDay + 1).ToString()?.PadLeft(3, '0');
    }
}
