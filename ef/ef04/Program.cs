using ef04.Services;
using ef04.Dto;
using ef04.Models;

class Program
{
    static void Main()
    {
        // Them nguyen lieu
        ThemNguyenLieuDto themNguyenLieuDto = new ThemNguyenLieuDto()
        {
            TenLoai = "Gia dụng",
            TenNguyenLieu = "Nước rửa bát",
            GiaBan = 20000
        };
        NguyenLieuService nguyenLieuService = new NguyenLieuService(new PhieuThuDBContext());
        nguyenLieuService.ThemNguyenLieu(themNguyenLieuDto);
    }
}
