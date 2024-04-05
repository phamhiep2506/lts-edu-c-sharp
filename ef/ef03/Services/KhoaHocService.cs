using ef03.Dto;
using ef03.IService;
using ef03.Models;

namespace ef03.Service;

public class KhoaHocService : IKhoaHocService
{
    private KhoaHocDbContext _context;
    public KhoaHocService(KhoaHocDbContext khoaHocDbContext)
    {
        _context = khoaHocDbContext;
    }

    public void ThemKhoaHoc(KhoaHocDto khoaHocDto)
    {
        KhoaHoc khoaHoc = new KhoaHoc()
        {
            TenKhoaHoc = khoaHocDto.TenKhoaHoc,
            MoTa = khoaHocDto.MoTa != null ? khoaHocDto.MoTa : null,
            HocPhi = khoaHocDto.HocPhi,
            NgayBatDau = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            NgayKetThuc = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 15)
        };

        _context.Add(khoaHoc);
        _context.SaveChanges();
    }

    public int GetKhoaHocId(string tenKhoaHoc)
    {
        int khoaHocId = _context.khoaHocs!
            .Where(o => o.TenKhoaHoc == tenKhoaHoc)
            .Select(o => o.KhoaHocId)
            .SingleOrDefault();

        return khoaHocId;
    }
}