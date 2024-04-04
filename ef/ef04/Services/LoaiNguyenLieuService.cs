using ef04.Dto;
using ef04.Models;

namespace ef04.Services;

public class LoaiNguyenLieuService : ILoaiNguyenLieuService
{
    private PhieuThuDBContext _context { get; set; }

    public LoaiNguyenLieuService(PhieuThuDBContext phieuThuDBContext)
    {
        _context = phieuThuDBContext;
    }

    public void ThemLoaiNguyenLieu(ThemLoaiNguyenLieuDto themLoaiNguyenLieuDto)
    {
        bool isTenLoai = _context.loaiNguyenLieus!.Any(o => o.TenLoai == themLoaiNguyenLieuDto.TenLoai);

        if (!isTenLoai)
        {
            LoaiNguyenLieu loaiNguyenLieu = new LoaiNguyenLieu();
            loaiNguyenLieu.TenLoai = themLoaiNguyenLieuDto.TenLoai;

            _context.Add(loaiNguyenLieu);
            _context.SaveChanges();
        }
    }

    public int GetLoaiNguyenLieuId(ThemLoaiNguyenLieuDto themLoaiNguyenLieuDto)
    {
        int loaiNguyenLieuId = _context
          .loaiNguyenLieus!
          .Where(o => o.TenLoai == themLoaiNguyenLieuDto.TenLoai)
          .Select(o => o.LoaiNguyenLieuId)
          .SingleOrDefault();

        return loaiNguyenLieuId;
    }
}
