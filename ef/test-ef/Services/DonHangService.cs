using Microsoft.EntityFrameworkCore;
using test_ef.Dtos;
using test_ef.IServices;
using test_ef.Models;

namespace test_ef.Services;

public class DonHangService : IDonHangService
{
    private AppDbContext _context;

    public DonHangService()
    {
        _context = new AppDbContext();
    }

    public List<DonHangIdSanPhamDto> Lay3SanPhamDoVietNamSX()
    {
        List<DonHangIdSanPhamDto> donHangIdSanPhamDtos = _context
            .ChiTietDonDatHang.Include(x => x.SanPham)
            .Where(x => x.SanPham.NhaSanXuat == "Việt Nam")
            .Select(x => new DonHangIdSanPhamDto()
            {
                DonHangId = x.DonDatHangId,
                TenSanPham = x.SanPham.TenSanPham,
                NhaSanXuat = x.SanPham.NhaSanXuat
            })
            .Take(3)
            .ToList();
        return donHangIdSanPhamDtos;
    }

    public int LayThang2019DanhSoCao()
    {
        int donDatHangId = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Where(x => x.DonDatHang.NgayDat.Year == 2019)
            .GroupBy(x => x.DonDatHangId)
            .OrderByDescending(x => x.Count())
            .Select(x => x.Key)
            .FirstOrDefault();
        int thang = _context
            .DonDatHang.Where(x => x.DonDatHangId == donDatHangId)
            .Select(x => x.NgayDat.Month)
            .FirstOrDefault();
        return thang;
    }

    public decimal LayGiaTriHoaDonCaoNhat()
    {
        var a = _context
            .ChiTietDonDatHang.Include(x => x.SanPham)
            .GroupBy(x => x.SanPhamId)
            .Select(x => new { SanPhamId = x.Key, SoLuong = x.Sum(x => x.SoLuong) })
            .OrderByDescending(x => x.SoLuong)
            .FirstOrDefault();
        if (a == null)
        {
            return 0;
        }
        decimal giaTriHoaDonCaoNhat = _context
            .SanPham.Where(x => x.SanPhamId == a.SanPhamId)
            .Select(x => x.GiaBan * a.SoLuong)
            .FirstOrDefault();
        return giaTriHoaDonCaoNhat;
    }

    public decimal LayGiaTriHoaDonThapNhat()
    {
        var a = _context
            .ChiTietDonDatHang.Include(x => x.SanPham)
            .GroupBy(x => x.SanPhamId)
            .Select(x => new { SanPhamId = x.Key, SoLuong = x.Sum(x => x.SoLuong) })
            .OrderBy(x => x.SoLuong)
            .FirstOrDefault();
        if (a == null)
        {
            return 0;
        }
        decimal giaTriHoaDonThapNhat = _context
            .SanPham.Where(x => x.SanPhamId == a.SanPhamId)
            .Select(x => x.GiaBan * a.SoLuong)
            .FirstOrDefault();
        return giaTriHoaDonThapNhat;
    }

    public List<int> LayHoaDon3LoaiSP()
    {
        List<int> loaiSanPhamId = _context
            .ChiTietDonDatHang.Include(x => x.SanPham)
            .GroupBy(x => x.DonDatHangId)
            .Where(x => x.Select(x => x.SanPham.LoaiSanPhamId).Distinct().Count() == 3)
            .Select(x => x.Key)
            .ToList();

        return loaiSanPhamId;
    }
}
