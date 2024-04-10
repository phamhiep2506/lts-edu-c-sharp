using test_ef.Dtos;
using test_ef.Services;

namespace test_ef.Views;

public class KhachHang
{
    public void HienKhachHangMuaNhieuNhat()
    {
        KhachHangService khachHangService = new KhachHangService();
        string hoTen = khachHangService.LayKhachHangMuaNhieuNhat();
        Console.WriteLine($"HoTen: {hoTen}");
    }

    public void HienKhachHangMuaSanPhamHaNoi()
    {
        KhachHangService khachHangService = new KhachHangService();
        List<KhachHangDto> khachHangDtos = khachHangService.LayKhachHangMuaSanPhamHaNoi();
        khachHangDtos.ForEach(x =>
        {
            Console.WriteLine($"HoTen: {x.HoTen} - DiaChi: {x.DiaChi}");
        });
    }

    public void HienKhachHangDatTren100SP()
    {
        KhachHangService khachHangService = new KhachHangService();
        List<KhachHangSLDto> khachHangDtos = khachHangService.LayKhachHangDatTren100SP();
        khachHangDtos.ForEach(x =>
        {
            Console.WriteLine($"HoTen: {x.HoTen} - DiaChi: {x.DiaChi} - SoLuong: {x.SoLuongSP}");
        });
    }
}
