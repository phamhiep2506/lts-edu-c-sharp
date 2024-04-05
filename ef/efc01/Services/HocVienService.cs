using efc01.IServices;
using efc01.Models;
using efc01.Dto;

namespace efc01.Services;

public class HocVienService : IHocVienService
{
    private IeltsDbContext _context;

    public HocVienService()
    {
        _context = new IeltsDbContext();
    }

    public void ThemHocVien(ThemHocVienDto themHocVienDto)
    {
        HocVien hocVien = new HocVien();
        hocVien.HoTen = themHocVienDto.HoTen;
        hocVien.Ngaysinh = themHocVienDto.NgaySinh;
        hocVien.GioiTinh = themHocVienDto.GioiTinh;
        hocVien.Email = themHocVienDto.Email;
        hocVien.SoDienThoai = themHocVienDto.SoDienThoai;

        _context.Add(hocVien);
        _context.SaveChanges();
    }

    public void CapNhatHocVien(CapNhatHocVienDto capNhatHocVien)
    {
        HocVien? hocVien = _context
            .HocViens?
            .Where(x => x.HoTen == capNhatHocVien.HoTen)
            .SingleOrDefault();
        if (hocVien != null)
        {
            hocVien.Ngaysinh = capNhatHocVien.NgaySinh;
            hocVien.GioiTinh = capNhatHocVien.GioiTinh;
            hocVien.Email = capNhatHocVien.Email;
            hocVien.SoDienThoai = capNhatHocVien.SoDienThoai;
            hocVien.DiaChi = capNhatHocVien.DiaChi != null ? capNhatHocVien.DiaChi : string.Empty;
            hocVien.TrinhDo = capNhatHocVien.TrinhDo != null ? capNhatHocVien.TrinhDo : string.Empty;
            hocVien.NgayDangKy = capNhatHocVien.NgayDangKy != null ? capNhatHocVien.NgayDangKy : new DateTime();

            _context.Update(hocVien);
            _context.SaveChanges();
        }
    }

    public void XoaHocVien(XoaHocVienDto xoaHocVienDto)
    {
        HocVien? hocVien = _context
            .HocViens?
            .Where(x => x.HoTen == xoaHocVienDto.HoTen)
            .SingleOrDefault();
        if(hocVien != null)
        {
            _context.Remove(hocVien);
            _context.SaveChanges();
        }
    }
}
