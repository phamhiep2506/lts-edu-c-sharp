using ef05.Dtos;
using ef05.Models;

namespace ef05.Services;

public class CongThucService : ICongThucService
{
    private MonAnDbContext _context;
    public CongThucService()
    {
        _context = new MonAnDbContext();
    }

    public void ThemCongThuc(List<ThemCongThucDto> themCongThucDto)
    {
        themCongThucDto.ForEach(x => {
            NguyenLieu nguyenLieu = new NguyenLieu()
            {
                TenNguyenLieu = x.TenNguyenLieu
            };
            _context.Add(nguyenLieu);
            _context.SaveChanges();

            CongThuc congThuc = new CongThuc()
            {
                NguyenLieuId = nguyenLieu.NguyenLieuId,
                MonAnId = new MonAnService().GetMonAnId(x.TenMonAn),
                SoLuong = x.SoLuong,
                DonViTinh = x.DonViTinh
            };
            _context.Add(congThuc);
            _context.SaveChanges();
        });
    }
}