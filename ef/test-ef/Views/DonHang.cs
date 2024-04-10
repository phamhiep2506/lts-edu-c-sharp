using test_ef.Dtos;
using test_ef.Services;

namespace test_ef.Views;

public class DonHang
{
    public void Hien3SanPhamDoVietNamSX()
    {
        DonHangService donHangService = new DonHangService();
        List<DonHangIdSanPhamDto> donHangIdSanPhamDtos = donHangService.Lay3SanPhamDoVietNamSX();
        donHangIdSanPhamDtos.ForEach(x =>
        {
            Console.WriteLine(
                $"DonHangId: {x.DonHangId} - TenSanPham: {x.TenSanPham} - NhaSanXuat: {x.NhaSanXuat}"
            );
        });
    }

    public void HienThang2019DanhSoCao()
    {
        DonHangService donHangService = new DonHangService();
        int thangDanhThuCaoNhat = donHangService.LayThang2019DanhSoCao();
        Console.WriteLine($"Thang: {thangDanhThuCaoNhat}");
    }

    public void HienGiaTriHoaDonCaoNhat()
    {
        DonHangService donHangService = new DonHangService();
        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
        decimal giaTriHoaDonCaoNhat = donHangService.LayGiaTriHoaDonCaoNhat();
        Console.WriteLine(
            $"GiaTriHoaDonCaoNhat: {string.Format(info, "{0:c}", giaTriHoaDonCaoNhat)}"
        );
    }

    public void HienGiaTriHoaDonThapNhat()
    {
        DonHangService donHangService = new DonHangService();
        var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
        decimal giaTriHoaDonThapNhat = donHangService.LayGiaTriHoaDonThapNhat();
        Console.WriteLine(
            $"GiaTriHoaDonCaoNhat: {string.Format(info, "{0:c}", giaTriHoaDonThapNhat)}"
        );
    }

    public void HienHoaDon3LoaiSP()
    {
        DonHangService donHangService = new DonHangService();
        List<int> thongTinSanPhamDtos = donHangService.LayHoaDon3LoaiSP();
        thongTinSanPhamDtos.ForEach(x =>
        {
            Console.WriteLine($"HoaDonId: {x}");
        });
    }
}
