using efc02.Models;

namespace efc02.Services;

public class NguyenLieuService : INguyenLieuService
{
    private CongThucNauAnDbContext _context;

    public NguyenLieuService()
    {
        _context = new CongThucNauAnDbContext();
    }

    public void ThemNguyenLieu(string tenNguyenLieu)
    {
        bool isNguyenLieu = _context.NguyenLieu.Any(x => x.TenNguyenLieu == tenNguyenLieu);
        if (isNguyenLieu)
        {
            return;
        }

        NguyenLieu nguyenLieu = new NguyenLieu() { TenNguyenLieu = tenNguyenLieu };
        _context.Add(nguyenLieu);
        _context.SaveChanges();
    }

    public int GetNguyenLieuId(string tenNguyenLieu)
    {
        int nguyenLieuId = _context
            .NguyenLieu.Where(x => x.TenNguyenLieu == tenNguyenLieu)
            .Select(x => x.NguyenLieuId)
            .SingleOrDefault();
        return nguyenLieuId;
    }
}
