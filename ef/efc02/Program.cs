using efc02.Dtos;
using efc02.Services;

public class Program
{
    public static void Main()
    {
        // ThemNguyenLieuDto themNguyenLieuDto1 = new ThemNguyenLieuDto()
        // {
        //     TenNguyenLieu = "Thịt heo",
        //     SoLuong = 1,
        //     DonViTinh = "Kg"
        // };
        // ThemNguyenLieuDto themNguyenLieuDto2 = new ThemNguyenLieuDto()
        // {
        //     TenNguyenLieu = "Hành",
        //     SoLuong = 1,
        //     DonViTinh = "Củ"
        // };
        // ThemNguyenLieuDto themNguyenLieuDto3 = new ThemNguyenLieuDto()
        // {
        //     TenNguyenLieu = "Mỡ",
        //     SoLuong = 1,
        //     DonViTinh = "muỗng"
        // };
        // List<ThemNguyenLieuDto> themNguyenLieuDtos = new List<ThemNguyenLieuDto>();
        // themNguyenLieuDtos.Add(themNguyenLieuDto1);
        // themNguyenLieuDtos.Add(themNguyenLieuDto2);
        // themNguyenLieuDtos.Add(themNguyenLieuDto3);

        // MonAnService monAnService = new MonAnService();
        // ThemMonAnDto themMonAnDto = new ThemMonAnDto()
        // {
        //     TenMon = "Thịt nướng",
        //     TenLoai = "Món nướng",
        //     ThemNguyenLieuDtos = themNguyenLieuDtos
        // };
        // monAnService.ThemMonAn(themMonAnDto);

        MonAnService monAnService = new MonAnService();
        monAnService.HienMonAn();
    }
}
