using ef03.Dto;
using ef03.IService;
using ef03.Models;
using ef03.Service;
using Microsoft.IdentityModel.Tokens;

public class Program
{
     
    static void Main()
    {
        // KhoaHocService khoaHocService = new KhoaHocService(new KhoaHocDbContext());

        // khoaHocService.ThemKhoaHoc(new KhoaHocDto()
        // {
        //     TenKhoaHoc = "Toán"
        // });

        // NgayHocService ngayHocService = new NgayHocService(new KhoaHocDbContext());
        // ngayHocService.ThemNgayHoc(new NgayHocDto(){
        //     TenKhoaHoc = "Toán"
        // });

        // HocVienService hocVienService = new HocVienService(new KhoaHocDbContext());
        // hocVienService.ThemHocVien(new ThemHocVienDto() {
        //     HoTen = "Phạm Văn Hiệp",
        //     TenKhoaHoc = "Toán"
        // });
        HocVienService hocVienService = new HocVienService();

        hocVienService.SuaHocVien(
            new SuaHocVienDto() {
                TenKhoaHoc = "Toán",
                HoTen = "Phạm Văn Hiệp",
                NgaySinh = new DateTime(2000, 06, 25),
                QueQuan = "Hà Nội",
                DiaChi = "Hà Nội",
                SoDienThoai = 1234567
            }
        );
    }
}
