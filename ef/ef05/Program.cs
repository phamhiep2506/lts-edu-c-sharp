using ef05.Dtos;
using ef05.Services;

public class Program
{
    static void Main()
    {
        // MonAnService monAnService = new MonAnService();
        // ThemMonAnDto themMonAnDto = new ThemMonAnDto()
        // {
        //     TenMon = "Cá nấu",
        //     TenLoai = "Nấu",
        //     GiaBan = 50000
        // };
        // monAnService.ThemMonAn(themMonAnDto);
        List<ThemCongThucDto> themCongThucDtos = new List<ThemCongThucDto>()
        {
            new ThemCongThucDto()
            {
                TenMonAn = "Cá nấu",
                TenNguyenLieu = "Cá",
                SoLuong = 1,
                DonViTinh = "Con"
            },
            new ThemCongThucDto()
            {
                TenMonAn = "Cá nấu",
                TenNguyenLieu = "Hành",
                SoLuong = 1,
                DonViTinh = "Củ"
            },
            new ThemCongThucDto()
            {
                TenMonAn = "Cá nấu",
                TenNguyenLieu = "Mỡ",
                SoLuong = 1,
                DonViTinh = "muỗng"
            }
        };

        CongThucService congThucService = new CongThucService();
        congThucService.ThemCongThuc(themCongThucDtos);
    }
}