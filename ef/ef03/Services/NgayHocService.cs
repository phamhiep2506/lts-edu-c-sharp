using ef03.Dto;
using ef03.IService;
using ef03.Models;

namespace ef03.Service;

public class NgayHocService : INgayHocService
{
    private KhoaHocDbContext _context;

    public NgayHocService(KhoaHocDbContext khoaHocDbContext)
    {
        _context = khoaHocDbContext;
    }

    public void ThemNgayHoc(NgayHocDto ngayHocDto)
    {
        NgayHoc ngayHoc = new NgayHoc();

        int? khoaHocId = new KhoaHocService(_context).GetKhoaHocId(ngayHocDto.TenKhoaHoc);
        if(khoaHocId != null) 
        {
            ngayHoc.KhoaHocId = khoaHocId;

            _context.Add(ngayHoc);
            _context.SaveChanges();
        }
    }
}