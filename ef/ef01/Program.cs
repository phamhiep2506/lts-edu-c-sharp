using ef01.Services;
using ef01.Models;

public class Program
{
    static void Main(string[] args)
    {
        LopService lopService = new LopService();
        HocSinhService hocSinhService = new HocSinhService();

        // Insert data to database
        // Lop lop = new Lop
        // {
        //     TenLop = "Toán",
        //     SiSo = 20
        // };
        // HocSinh hocSinh = new HocSinh
        // {
        //     LopID = 1,
        //     HoTen = "Phạm Văn Hiệp",
        //     NgaySinh = new DateTime(2000, 06, 25),
        //     QueQuan = "Nam Định"
        // };
        // lopService.ThemThongTinLop(lop);
        // hocSinhService.ThemThongTinHocSinh(hocSinh);

        // Update data on database
        // HocSinh hocSinhUpdate = new HocSinh
        // {
        //     LopID = 1,
        //     HoTen = "Phạm Văn Hiệp",
        //     NgaySinh = new DateTime(2000, 06, 25),
        //     QueQuan = "Nghĩa Thái, Nghĩa Hưng, Nam Định"
        // };
        // hocSinhService.SuaThongTinHocSinh(2, hocSinhUpdate);

        // Delete data on database
        // hocSinhService.XoaThongTinHocSinh(2);

        // Change LopID on database
        /* hocSinhService.DoiThongTinLopHocSinh(5, 3); */
    }
}
