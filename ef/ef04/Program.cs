using ef04.Services;
using ef04.Dto;
using ef04.Models;

class Program
{
    static void Main()
    {
        // Them nguyen lieu
        // ThemNguyenLieuDto themNguyenLieuDto = new ThemNguyenLieuDto()
        // {
        //     TenLoai = "Gia dụng",
        //     TenNguyenLieu = "Nước rửa bát",
        //     GiaBan = 20000
        // };
        // NguyenLieuService nguyenLieuService = new NguyenLieuService(new PhieuThuDBContext());
        // nguyenLieuService.ThemNguyenLieu(themNguyenLieuDto);

        // Them phieu thu
        // List<ThemChiTietPhieuThuDto> themChiTietPhieuThuDtos = new List<ThemChiTietPhieuThuDto>();
        // themChiTietPhieuThuDtos.AddRange(new List<ThemChiTietPhieuThuDto>
        // {
        //     new ThemChiTietPhieuThuDto()
        //     {
        //         TenNguyenLieu = "Hảo Hảo",
        //         SoLuongBan = 5
        //     },
        //     new ThemChiTietPhieuThuDto()
        //     {
        //         TenNguyenLieu = "Kokomi",
        //         SoLuongBan = 5
        //     }
        // });

        // ThemPhieuThuDto themPhieuThuDto = new ThemPhieuThuDto()
        // {
        //     NhanVienLap = "Phạm Văn Hiệp",
        //     ThanhTien = 50000,
        //     ThemChiTietPhieuThuDtos = themChiTietPhieuThuDtos
        // };

        // PhieuThuService phieuThuService = new PhieuThuService(new PhieuThuDBContext());
        // phieuThuService.ThemPhieuThu(themPhieuThuDto);

        // Xoa phieu thu
        // XoaPhieuThuDto xoaPhieuThuDto = new XoaPhieuThuDto()
        // {
        //     PhieuThuId = 1
        // };
        // PhieuThuService phieuThuService = new PhieuThuService(new PhieuThuDBContext());
        // phieuThuService.XoaPhieuThu(xoaPhieuThuDto);
    }
}
