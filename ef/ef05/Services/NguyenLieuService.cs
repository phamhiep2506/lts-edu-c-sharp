using ef05.Dtos;
using ef05.Models;

namespace ef05.Services;

public class NguyenLieuService : INguyenLieuService
{
    private MonAnDbContext _context;
    public NguyenLieuService()
    {
        _context = new MonAnDbContext();
    }

    public void ThemNguyenLieu(ThemNguyenLieuDto themNguyenLieuDto)
    {
        NguyenLieu nguyenLieu = new NguyenLieu()
        {
            TenNguyenLieu = themNguyenLieuDto.TenNguyenLieu,
            GhiChu = themNguyenLieuDto.GhiChu
        };
    }
}