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
            Console.WriteLine($"{thongTinSanPham.TenSanPham} - {thongTinSanPham.TenLoai}");
        });
    }
}
