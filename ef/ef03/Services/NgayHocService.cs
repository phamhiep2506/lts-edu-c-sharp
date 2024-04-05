using ef03.Dto;
using ef03.IService;
using ef03.Models;

namespace ef03.Service;

public class NgayHocService : INgayHocService
{
    private KhoaHocDbContext _context;

    public NgayHocService()
    {
        _context = new KhoaHocDbContext();
    }

    public void ThemNgayHoc(NgayHocDto ngayHocDto)
    {
        NgayHoc ngayHoc = new NgayHoc();

        int? khoaHocId = new KhoaHocService().GetKhoaHocId(ngayHocDto.TenKhoaHoc);
        if(khoaHocId != null)
        {
            ngayHoc.KhoaHocId = khoaHocId;

            _context.Add(ngayHoc);
            _context.SaveChanges();
        }
    }
}
