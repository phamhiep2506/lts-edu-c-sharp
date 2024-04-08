using efc02.Models;
using efc02.Dtos;

namespace efc02.Services;

public class CongThucService : ICongThucService
{
    private CongThucNauAnDbContext _context;
    public CongThucService()
    {
        _context = new CongThucNauAnDbContext();
    }

    public void ThemCongThuc(ThemCongThucDto themCongThucDto)
    {
        CongThuc congThuc = new CongThuc()
        {
            MonAnId = themCongThucDto.MonAnId,
            NguyenLieuId = themCongThucDto.NguyenLieuId,
            SoLuong = themCongThucDto.SoLuong,
            DonViTinh = themCongThucDto.DonViTinh
        };
        _context.Add(congThuc);
        _context.SaveChanges();
    }
}
