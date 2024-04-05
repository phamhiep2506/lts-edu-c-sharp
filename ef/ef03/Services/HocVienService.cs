using ef03.Dto;
using ef03.IService;
using ef03.Models;

namespace ef03.Service;

public class HocVienService : IHocVienService
{
    private KhoaHocDbContext _context;
    public HocVienService()
    {
        _context = new KhoaHocDbContext();
    }

    public void ThemHocVien(ThemHocVienDto themHocVienDto)
    {
        HocVien hocVien = new HocVien();
        hocVien.HoTen = themHocVienDto.HoTen;
        int getKhoaHocId = new KhoaHocService(_context).GetKhoaHocId(themHocVienDto.TenKhoaHoc);
        hocVien.KhoaHocId = getKhoaHocId;

        _context.Add(hocVien);
        _context.SaveChanges();
    }

    public void SuaHocVien(SuaHocVienDto suaHocVienDto)
    {
        HocVien? hocVien = _context
            .hocViens?
            .Where(o => o.HoTen == suaHocVienDto.HoTen)
            .SingleOrDefault();
        
        if(hocVien != null)
        {
            hocVien.KhoaHocId = new KhoaHocService(_context).GetKhoaHocId(suaHocVienDto.TenKhoaHoc);
            hocVien.NgaySinh = suaHocVienDto.NgaySinh;
            hocVien.QueQuan = suaHocVienDto.QueQuan;
            hocVien.DiaChi = suaHocVienDto.DiaChi;
            hocVien.SoDienThoai = suaHocVienDto.SoDienThoai;

            _context.Update(hocVien);
            _context.SaveChanges();
        }
    }
}