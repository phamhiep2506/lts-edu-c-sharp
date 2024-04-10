using Microsoft.EntityFrameworkCore;
using test_ef.Dtos;
using test_ef.IServices;
using test_ef.Models;

namespace test_ef.Services;

public class SanPhamService : ISanPhamService
{
    private AppDbContext _context;

    public SanPhamService()
    {
        _context = new AppDbContext();
    }

    public List<ThongTinSanPhamDto> LayThongTinSanPham()
    {
        List<ThongTinSanPhamDto> thongTinSanPhams = _context
            .SanPham.Include(x => x.LoaiSanPham)
            .Select(x => new ThongTinSanPhamDto()
            {
                TenSanPham = x.TenSanPham,
                TenLoai = x.LoaiSanPham.TenLoai
            })
            .ToList();
        return thongTinSanPhams;
    }

    public List<ThongTinSanPhamDateDto> LayThongTinSanPhamBanDuocNam2019()
    {
        List<ThongTinSanPhamDateDto> thongTinSanPhamDates = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .ThenInclude(x => x.LoaiSanPham)
            .Where(x => x.DonDatHang.NgayDat.Year == 2019)
            .Select(x => new ThongTinSanPhamDateDto()
            {
                TenSanPham = x.SanPham.TenSanPham,
                TenLoai = x.SanPham.LoaiSanPham.TenLoai,
                NgayDat = x.DonDatHang.NgayDat
            })
            .ToList();
        return thongTinSanPhamDates;
    }

    public List<ThongTinSanPhamDateDto> LaySanPhamTDoAnTrongNgay25052020()
    {
        List<ThongTinSanPhamDateDto> thongTinSanPhams = _context
            .SanPham.Include(x => x.LoaiSanPham)
            .Where(x =>
                (x.NgayDang == new DateTime(2020, 05, 25)) && (x.LoaiSanPham.TenLoai == "Đồ ăn")
            )
            .Select(x => new ThongTinSanPhamDateDto
            {
                TenSanPham = x.TenSanPham,
                TenLoai = x.LoaiSanPham.TenLoai,
                NgayDat = x.NgayDang
            })
            .ToList();
        return thongTinSanPhams;
    }

    public List<SHDSanPhamSLDto> LaySanPhamTDoAnDoUong()
    {
        List<SHDSanPhamSLDto> sHDSanPhamSLs = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .ThenInclude(x => x.LoaiSanPham)
            .Where(x =>
                (
                    x.SanPham.LoaiSanPham.TenLoai == "Đồ ăn"
                    || x.SanPham.LoaiSanPham.TenLoai == "Đồ uống"
                )
                && x.SoLuong >= 10
                && x.SoLuong <= 20
            )
            .Select(x => new SHDSanPhamSLDto
            {
                SoHieuDon = x.DonDatHang.SoHieuDon,
                TenSanPham = x.SanPham.TenSanPham,
                TenLoai = x.SanPham.LoaiSanPham.TenLoai,
                SoLuong = x.SoLuong
            })
            .ToList();
        return sHDSanPhamSLs;
    }

    public decimal LayTongTienTrongNgay25052020()
    {
        decimal tongTien = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .Where(x => x.DonDatHang.NgayDat == new DateTime(2020, 05, 25))
            .Sum(x => x.SoLuong * x.SanPham.GiaBan);
        return tongTien;
    }

    public List<TongSoSanPhamTungHoaDonDto> LayTongSoSanPhamTungHoaDon()
    {
        List<TongSoSanPhamTungHoaDonDto> tongSoSanPhamTungHoaDonDtos = _context
            .ChiTietDonDatHang.GroupBy(x => x.DonDatHangId)
            .Select(x => new TongSoSanPhamTungHoaDonDto()
            {
                DonDatHangId = x.Key,
                TongSoSanPham = x.Sum(x => x.SoLuong)
            })
            .ToList();
        return tongSoSanPhamTungHoaDonDtos;
    }

    public ThongTinSanPhamDto LaySanPhamBanThapNhat2019()
    {
        var a = _context
            .ChiTietDonDatHang.GroupBy(x => x.SanPhamId)
            .Select(x => new { SanPhamId = x.Key, SoLuong = x.Sum(x => x.SoLuong) })
            .OrderBy(x => x.SoLuong)
            .FirstOrDefault();
        if (a == null)
        {
            return new ThongTinSanPhamDto() { };
        }
        ThongTinSanPhamDto? thongTinSanPhamDto = _context
            .SanPham.Include(x => x.LoaiSanPham)
            .Where(x => x.SanPhamId == a.SanPhamId)
            .Select(x => new ThongTinSanPhamDto()
            {
                TenSanPham = x.TenSanPham,
                TenLoai = x.LoaiSanPham.TenLoai
            })
            .FirstOrDefault();
        if (thongTinSanPhamDto == null)
        {
            return new ThongTinSanPhamDto() { };
        }
        return thongTinSanPhamDto;
    }

    public List<ThongTinSanPhamDateDto> LaySanPhamBanRa09062020()
    {
        List<ThongTinSanPhamDateDto> thongTinSanPhamDateDtos = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .ThenInclude(x => x.LoaiSanPham)
            .Where(x => x.DonDatHang.NgayDat == new DateTime(2020, 06, 09))
            .Select(x => new ThongTinSanPhamDateDto()
            {
                TenSanPham = x.SanPham.TenSanPham,
                TenLoai = x.SanPham.LoaiSanPham.TenLoai,
                NgayDat = x.DonDatHang.NgayDat
            })
            .ToList();
        return thongTinSanPhamDateDtos;
    }

    public List<ThongTinSanPhamSLDto> LaySanPhamChiDat1Lan()
    {
        List<ThongTinSanPhamSLDto> thongTinSanPhamSLDtos = _context
            .ChiTietDonDatHang.Include(x => x.SanPham)
            .ThenInclude(x => x.LoaiSanPham)
            .GroupBy(x => new { x.SanPham.TenSanPham, x.SanPham.LoaiSanPham.TenLoai })
            .Select(x => new ThongTinSanPhamSLDto()
            {
                SoLuongDonDatHang = x.Count(),
                TenSanPham = x.Key.TenSanPham,
                TenLoai = x.Key.TenLoai
            })
            .Where(x => x.SoLuongDonDatHang == 1)
            .ToList();

        return thongTinSanPhamSLDtos;
    }
}
