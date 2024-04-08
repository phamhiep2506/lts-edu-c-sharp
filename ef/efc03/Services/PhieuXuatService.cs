using efc03.Dtos;
using efc03.Models;

namespace efc03.Services;

public class PhieuXuatService : IPhieuXuatService
{
    private VatTuDbContext _context;

    public PhieuXuatService()
    {
        _context = new VatTuDbContext();
    }

    public void ThemPhieuXuat(PhieuXuatDto phieuXuatDto)
    {
        PhieuXuat phieuXuat = new PhieuXuat()
        {
            MaPhieu = phieuXuatDto.MaPhieu,
            TieuDe = phieuXuatDto.TieuDe,
            NgayXuat = DateTime.Now
        };
        _context.Add(phieuXuat);
        _context.SaveChanges();

        ChiTietPhieuXuat chiTietPhieuXuat = new ChiTietPhieuXuat()
        {
            VatTuId = new VatTuService().GetVatTuId(phieuXuatDto.TenVatTu),
            PhieuXuatId = phieuXuat.PhieuXuatId,
            SoLuongXuat = phieuXuatDto.SoLuongXuat
        };
        _context.Add(chiTietPhieuXuat);
        _context.SaveChanges();
    }
}
