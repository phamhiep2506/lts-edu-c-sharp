using efc03.Dtos;
using efc03.Models;

namespace efc03.Services;

public class PhieuNhapService : IPhieuNhapService
{
    private VatTuDbContext _context;

    public PhieuNhapService()
    {
        _context = new VatTuDbContext();
    }

    public void ThemPhieuNhap(PhieuNhapDto phieuNhapDto)
    {
        PhieuNhap phieuNhap = new PhieuNhap()
        {
            MaPhieu = phieuNhapDto.MaPhieu,
            TieuDe = phieuNhapDto.TieuDe,
            NgayNhap = DateTime.Now
        };
        _context.Add(phieuNhap);
        _context.SaveChanges();

        ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap()
        {
            VatTuId = new VatTuService().GetVatTuId(phieuNhapDto.TenVatTu),
            PhieuNhapId = phieuNhap.PhieuNhapId,
            SoLuongNhap = phieuNhapDto.SoLuongNhap
        };
        _context.Add(chiTietPhieuNhap);
        _context.SaveChanges();
    }
}
