using test_ef.Dtos;
using test_ef.Services;

namespace test_ef.Views;

public class SanPham
{
    public void HienThongTinSanPham()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPham> thongTinSanPhams = sanPhamService.LayThongTinSanPham();
        thongTinSanPhams.ForEach(thongTinSanPham =>
        {
            Console.WriteLine($"TenSanPham: {thongTinSanPham.TenSanPham} - TenLoai: {thongTinSanPham.TenLoai}");
        });
    }

    public void HienThongTinSanPhamKhongBanDuocNam2019()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPhamDate> thongTinSanPhams =
            sanPhamService.LayThongTinSanPhamKhongBanDuocNam2019();
        thongTinSanPhams.ForEach(thongTinSanPham =>
        {
            Console.WriteLine(
                $"TenSanPham: {thongTinSanPham.TenSanPham} - TenLoai: {thongTinSanPham.TenLoai} - NgayDat: {thongTinSanPham.NgayDat}"
            );
        });
    }

    public void HienSanPhamTDoAnTrongNgay25052020()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPhamDate> thongTinSanPhams =
            sanPhamService.LaySanPhamTDoAnTrongNgay25052020();
        thongTinSanPhams.ForEach(thongTinSanPham =>
        {
            Console.WriteLine(
                $"TenSanPham: {thongTinSanPham.TenSanPham} - TenLoai: {thongTinSanPham.TenLoai} - NgayDat: {thongTinSanPham.NgayDat}"
            );
        });
    }

    public void HienSanPhamTDoAnDoUong()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<SHDSanPhamSL> sHDSanPhamSLs = sanPhamService.LaySanPhamTDoAnDoUong();
        sHDSanPhamSLs.ForEach(sHDSanPhamSL =>
        {
            Console.WriteLine(
                $"SoHieuDon: {sHDSanPhamSL.SoHieuDon} - TenSanPham: {sHDSanPhamSL.TenSanPham} - TenLoai: {sHDSanPhamSL.TenLoai} - SoLuong: {sHDSanPhamSL.SoLuong}"
            );
        });
    }

    public void HienTongTienTrongNgay25052020()
    {
        SanPhamService sanPhamService = new SanPhamService();
        decimal tongTien = sanPhamService.LayTongTienTrongNgay25052020();
        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
        Console.WriteLine($"TongTien: {string.Format(info, "{0:c}", tongTien)}");
    }
}
