using efc01.Dto;
using efc01.Services;

public class Program
{
    static void Main()
    {
        HocVienService hocVienService = new HocVienService();

        // hocVienService.ThemHocVien(new ThemHocVienDto() {
        //     HoTen = "Phạm Văn Hiệp",
        //     NgaySinh = new DateTime(2000, 06, 25),
        //     GioiTinh = "Nam",
        //     Email = "phamhiep25062k@gmail.com",
        //     SoDienThoai = "0375622336"
        // });

        // hocVienService.CapNhatHocVien(new CapNhatThongTinHocVien() {
        //         HoTen = "Phạm Văn Hiệp",
        //         NgaySinh = new DateTime(2000, 06, 25),
        //         GioiTinh = "Nam",
        //         Email = "phamhiep25062k@gmail.com",
        //         SoDienThoai = "0375622336",
        //         DiaChi = "Nghĩa thái, Nghĩa hưng, Nam định",
        //         TrinhDo = "Đại học",
        //         NgayDangKy = DateTime.Now
        // });

        // hocVienService.XoaHocVien(new XoaHocVienDto() {
        //         HoTen = "Phạm Văn Hiệp"
        // });
    }
}
