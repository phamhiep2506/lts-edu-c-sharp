using ef04.Dto;
using ef04.Models;

namespace ef04.Services;

public class NguyenLieuService : INguyenLieuService
{
    private PhieuThuDBContext _context { get; set; }

    public NguyenLieuService(PhieuThuDBContext phieuThuDBContext)
    {
        _context = phieuThuDBContext;
    }

    public void ThemNguyenLieu(ThemNguyenLieuDto themNguyenLieuDto)
    {

        LoaiNguyenLieuService loaiNguyenLieuService = new LoaiNguyenLieuService(_context);
        ThemLoaiNguyenLieuDto themLoaiNguyenLieuDto = new ThemLoaiNguyenLieuDto()
        {
            TenLoai = themNguyenLieuDto.TenLoai
        };

        loaiNguyenLieuService.ThemLoaiNguyenLieu(themLoaiNguyenLieuDto);

        NguyenLieu nguyenLieu = new NguyenLieu();
        nguyenLieu.LoaiNguyenLieuId = loaiNguyenLieuService.GetLoaiNguyenLieuId(themLoaiNguyenLieuDto);
        nguyenLieu.TenNguyenLieu = themNguyenLieuDto.TenNguyenLieu;
        nguyenLieu.GiaBan = themNguyenLieuDto.GiaBan;

        _context.Add(nguyenLieu);
        _context.SaveChanges();
    }
}
