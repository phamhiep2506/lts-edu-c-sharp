using ef04.Dto;
using ef04.Models;

namespace ef04.Services;

public class ChiTietPhieuThuService
{
    private PhieuThuDBContext _context;
    public ChiTietPhieuThuService(PhieuThuDBContext phieuThuDBContext)
    {
        _context = phieuThuDBContext;
    }

    public void ThemChiTietPhieuThu(ThemChiTietPhieuThuDto themChiTietPhieuThuDto, int phieuThuId)
    {
        ChiTietPhieuThu chiTietPhieuThu = new ChiTietPhieuThu();

        chiTietPhieuThu.NguyenLieuId = new NguyenLieuService(_context).GetNguyenLieuId(themChiTietPhieuThuDto.TenNguyenLieu);
        chiTietPhieuThu.PhieuThuId = phieuThuId;
        chiTietPhieuThu.SoLuongBan = themChiTietPhieuThuDto.SoLuongBan;
        _context.Add(chiTietPhieuThu);
        _context.SaveChanges();
    }
}