using ef04.Models;
using ef04.Dto;

namespace ef04.Services;

public class PhieuThuService
{
    private PhieuThuDBContext _context { get; set; }

    public PhieuThuService(PhieuThuDBContext phieuThuDBContext)
    {
        _context = phieuThuDBContext;
    }

    public void ThemPhieuThu(ThemPhieuThuDto themPhieuThuDto)
    {
        PhieuThu phieuThu = new PhieuThu();        
        phieuThu.NhanVienLap = themPhieuThuDto.NhanVienLap;
        phieuThu.ThanhTien = themPhieuThuDto.ThanhTien;

        _context.Add(phieuThu);
        _context.SaveChanges();

        foreach(ThemChiTietPhieuThuDto themChiTietPhieuThuDto in themPhieuThuDto.ThemChiTietPhieuThuDtos)
        {
            new ChiTietPhieuThuService(_context).ThemChiTietPhieuThu(
                themChiTietPhieuThuDto,
                phieuThu.PhieuThuId
            ); 
        }
    }

    public void XoaPhieuThu(XoaPhieuThuDto xoaPhieuThuDto)
    {
        PhieuThu? phieuThu = _context
            .phieuThus?
            .Where(o => o.PhieuThuId == xoaPhieuThuDto.PhieuThuId)
            .SingleOrDefault();
        
        if(phieuThu != null)
        {
            _context.Remove(phieuThu);
            _context.SaveChanges();
        }
    }
}