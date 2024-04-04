using ef02.Dto;
using ef02.Services;

class Program
{
    static void Main()
    {
        // Them nhan vien
        // NhanVienDto nhanVienModel = new NhanVienDto()
        // {
        //     HoTen = "Phạm Văn Hiệp",
        //     HeSoLuong = 1
        // };

        // NhanVienService nhanVienService = new NhanVienService();
        // nhanVienService.ThemNhanVien(nhanVienModel);

        // Them du an
        // DuAnDto duAnDto = new DuAnDto()
        // {
        //     TenDuAn = "Dự án 1"
        // };
        // DuAnService duAnService = new DuAnService();
        // duAnService.ThemDuAn(duAnDto);

        // Sua du an
        // SuaDuAnDto suaDuAnDto = new SuaDuAnDto()
        // {
        //     TenDuAnCu = "Dự án 1",
        //     TenDuAnMoi = "Dự án 2",
        //     Moto = "abc",
        //     GhiChu = "xyz"
        // };
        // DuAnService duAnService = new DuAnService();
        // duAnService.SuaDuAn(suaDuAnDto);

        // Xoa nhan vien
        // XoaNhanVienDto xoaNhanVienDto = new XoaNhanVienDto()
        // {
        //     HoTen = "Phạm Văn Hiệp"
        // };
        // NhanVienService nhanVienService = new NhanVienService();
        // nhanVienService.XoaNhanVien(xoaNhanVienDto);

        // Tinh luong
        TinhLuongNhanVienDto tinhLuongNhanVienDto = new TinhLuongNhanVienDto()
        {
            HoTen = "Phạm Văn Hiệp"
        };
        NhanVienService nhanVienService = new NhanVienService();
        int luongNhanVien = nhanVienService.TinhLuongNhanVien(tinhLuongNhanVienDto);
        Console.WriteLine(luongNhanVien);
    }
}
