using System.Security.Cryptography.X509Certificates;
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

    public List<ThongTinSanPham> LayThongTinSanPham()
    {
        List<ThongTinSanPham> thongTinSanPhams = _context
            .SanPham.Include(x => x.LoaiSanPham)
            .Select(x => new ThongTinSanPham()
            {
                TenSanPham = x.TenSanPham,
                TenLoai = x.LoaiSanPham.TenLoai
            })
            .ToList();
        return thongTinSanPhams;
    }

    public List<ThongTinSanPhamDate> LayThongTinSanPhamBanDuocNam2019()
    {
        List<ThongTinSanPhamDate> thongTinSanPhamDates = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .ThenInclude(x => x.LoaiSanPham)
            .Where(x => x.DonDatHang.NgayDat.Year == 2019)
            .Select(x => new ThongTinSanPhamDate()
            {
                TenSanPham = x.SanPham.TenSanPham,
                TenLoai = x.SanPham.LoaiSanPham.TenLoai,
                NgayDat = x.DonDatHang.NgayDat
            })
            .ToList();
        return thongTinSanPhamDates;
    }

    public List<ThongTinSanPhamDate> LaySanPhamTDoAnTrongNgay25052020()
    {
        List<ThongTinSanPhamDate> thongTinSanPhams = _context
            .SanPham.Include(x => x.LoaiSanPham)
            .Where(x =>
                (x.NgayDang == new DateTime(2020, 05, 25)) && (x.LoaiSanPham.TenLoai == "Đồ ăn")
            )
            .Select(x => new ThongTinSanPhamDate
            {
                TenSanPham = x.TenSanPham,
                TenLoai = x.LoaiSanPham.TenLoai,
                NgayDat = x.NgayDang
            })
            .ToList();
        return thongTinSanPhams;
    }

    public List<SHDSanPhamSL> LaySanPhamTDoAnDoUong()
    {
        List<SHDSanPhamSL> sHDSanPhamSLs = _context
            .ChiTietDonDatHang.Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .ThenInclude(x => x.LoaiSanPham)
            .Where(x =>
                (x.SanPham.LoaiSanPham.TenLoai == "Đồ ăn" || x.SanPham.LoaiSanPham.TenLoai == "Đồ uống")
                && x.SoLuong >= 10
                && x.SoLuong <= 20
            )
            .Select(x => new SHDSanPhamSL
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
            .ChiTietDonDatHang
            .Include(x => x.DonDatHang)
            .Include(x => x.SanPham)
            .Where(x => x.DonDatHang.NgayDat == new DateTime(2020, 05, 25))
            .Sum(x => x.SoLuong * x.SanPham.GiaBan);
        return tongTien;
    }
}
