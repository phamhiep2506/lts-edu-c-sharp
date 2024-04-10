using test_ef.Dtos;
using test_ef.Services;

namespace test_ef.Views;

public class SanPham
{
    public void HienThongTinSanPham()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPhamDto> thongTinSanPhams = sanPhamService.LayThongTinSanPham();
        thongTinSanPhams.ForEach(thongTinSanPham =>
        {
            Console.WriteLine(
                $"TenSanPham: {thongTinSanPham.TenSanPham} - TenLoai: {thongTinSanPham.TenLoai}"
            );
        });
    }

    public void HienThongTinSanPhamKhongBanDuocNam2019()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPhamDateDto> thongTinSanPhams =
            sanPhamService.LayThongTinSanPhamBanDuocNam2019();
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
        List<ThongTinSanPhamDateDto> thongTinSanPhams =
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
        List<SHDSanPhamSLDto> sHDSanPhamSLs = sanPhamService.LaySanPhamTDoAnDoUong();
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

    public void HienTongSoSanPhamTungHoaDon()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<TongSoSanPhamTungHoaDonDto> tongSoSanPhamTungHoaDonDtos =
            sanPhamService.LayTongSoSanPhamTungHoaDon();
        tongSoSanPhamTungHoaDonDtos.ForEach(x =>
        {
            Console.WriteLine($"DonHangId: {x.DonDatHangId} - TongSoSanPham: {x.TongSoSanPham}");
        });
    }

    public void HienSanPhamBanThapNhat2019()
    {
        SanPhamService sanPhamService = new SanPhamService();
        ThongTinSanPhamDto thongTinSanPhamDto = sanPhamService.LaySanPhamBanThapNhat2019();
        Console.WriteLine(
            $"TenSanPham: {thongTinSanPhamDto.TenSanPham} - TenLoai: {thongTinSanPhamDto.TenLoai}"
        );
    }

    public void HienSanPhamBanRa09062020()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPhamDateDto> thongTinSanPhamDateDtos =
            sanPhamService.LaySanPhamBanRa09062020();
        thongTinSanPhamDateDtos.ForEach(x =>
        {
            Console.WriteLine(
                $"TenSanPham: {x.TenSanPham} - TenLoai: {x.TenLoai} - NgayDat: {x.NgayDat}"
            );
        });
    }

    public void HienSanPhamChiDat1Lan()
    {
        SanPhamService sanPhamService = new SanPhamService();
        List<ThongTinSanPhamSLDto> thongTinSanPhamSLDtos = sanPhamService.LaySanPhamChiDat1Lan();
        thongTinSanPhamSLDtos.ForEach(x =>
        {
            Console.WriteLine(
                $"TenSanPham: {x.TenSanPham} - TenLoai: {x.TenLoai} - SoLuongDonDatHang: {x.SoLuongDonDatHang}"
            );
        });
    }
}
