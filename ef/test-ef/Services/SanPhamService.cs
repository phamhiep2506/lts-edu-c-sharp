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
            .SanPham.Join(
                _context.LoaiSanPham,
                sp => sp.LoaiSanPhamId,
                lsp => lsp.LoaiSanPhamId,
                (sp, lsp) =>
                    new ThongTinSanPham() { TenSanPham = sp.TenSanPham, TenLoai = lsp.TenLoai }
            )
            .ToList();
        return thongTinSanPhams;
    }

    public List<ThongTinSanPhamDate> LayThongTinSanPhamKhongBanDuocNam2019()
    {
        List<ThongTinSanPhamDate> thongTinSanPhams = _context
            .DonDatHang.Join(
                _context.ChiTietDonDatHang,
                ddh => ddh.DonDatHangId,
                ctddh => ctddh.DonDatHangId,
                (ddh, ctddh) => new { ddh, ctddh }
            )
            .Join(
                _context.SanPham,
                newJoinTable => newJoinTable.ctddh.SanPhamId,
                sp => sp.SanPhamId,
                (newJoinTable, sp) => new { newJoinTable, sp }
            )
            .Join(
                _context.LoaiSanPham,
                newJoinTable => newJoinTable.sp.LoaiSanPhamId,
                lsp => lsp.LoaiSanPhamId,
                (newJoinTable, lsp) => new { newJoinTable, lsp }
            )
            .Where(x => x.newJoinTable.newJoinTable.ddh.NgayDat.Year == 2019)
            .Select(x => new ThongTinSanPhamDate
            {
                TenSanPham = x.newJoinTable.sp.TenSanPham,
                TenLoai = x.lsp.TenLoai,
                NgayDat = x.newJoinTable.newJoinTable.ddh.NgayDat
            })
            .ToList();
        return thongTinSanPhams;
    }

    public List<ThongTinSanPhamDate> LaySanPhamTDoAnTrongNgay25052020()
    {
        List<ThongTinSanPhamDate> thongTinSanPhams = _context
            .SanPham.Join(
                _context.LoaiSanPham,
                sp => sp.LoaiSanPhamId,
                lsp => lsp.LoaiSanPhamId,
                (sp, lsp) => new { sp, lsp }
            )
            .Where(x => (x.sp.NgayDang == new DateTime(2020, 05, 25)) && (x.lsp.TenLoai == "Đồ ăn"))
            .Select(x => new ThongTinSanPhamDate
            {
                TenSanPham = x.sp.TenSanPham,
                TenLoai = x.lsp.TenLoai,
                NgayDat = x.sp.NgayDang
            })
            .ToList();
        return thongTinSanPhams;
    }

    public List<SHDSanPhamSL> LaySanPhamTDoAnDoUong()
    {
        List<SHDSanPhamSL> sHDSanPhamSLs = _context
            .DonDatHang.Join(
                _context.ChiTietDonDatHang,
                ddh => ddh.DonDatHangId,
                ctddh => ctddh.DonDatHangId,
                (ddh, ctddh) => new { ddh, ctddh }
            )
            .Join(
                _context.SanPham,
                newJoinTable => newJoinTable.ctddh.SanPhamId,
                sp => sp.SanPhamId,
                (newJoinTable, sp) => new { newJoinTable, sp }
            )
            .Join(
                _context.LoaiSanPham,
                newJoinTable => newJoinTable.sp.LoaiSanPhamId,
                lsp => lsp.LoaiSanPhamId,
                (newJoinTable, lsp) => new { newJoinTable, lsp }
            )
            .Where(x =>
                (x.lsp.TenLoai == "Đồ ăn" || x.lsp.TenLoai == "Đồ uống")
                && x.newJoinTable.newJoinTable.ctddh.SoLuong >= 10
                && x.newJoinTable.newJoinTable.ctddh.SoLuong <= 20
            )
            .Select(x => new SHDSanPhamSL
            {
                SoHieuDon = x.newJoinTable.newJoinTable.ddh.SoHieuDon,
                TenSanPham = x.newJoinTable.sp.TenSanPham,
                TenLoai = x.lsp.TenLoai,
                SoLuong = x.newJoinTable.newJoinTable.ctddh.SoLuong
            })
            .ToList();
        return sHDSanPhamSLs;
    }

    public decimal LayTongTienTrongNgay25052020()
    {
        decimal tongTien = _context
            .DonDatHang.Join(
                _context.ChiTietDonDatHang,
                ddh => ddh.DonDatHangId,
                ctddh => ctddh.DonDatHangId,
                (ddh, ctddh) => new { ddh, ctddh }
            )
            .Join(
                _context.SanPham,
                newJoinTable => newJoinTable.ctddh.SanPhamId,
                sp => sp.SanPhamId,
                (newJoinTable, sp) => new { newJoinTable, sp }
            )
            .Where(x => x.newJoinTable.ddh.NgayDat == new DateTime(2020, 05, 25))
            .Sum(x => x.newJoinTable.ctddh.SoLuong * x.sp.GiaBan);
        return tongTien;
    }
}
