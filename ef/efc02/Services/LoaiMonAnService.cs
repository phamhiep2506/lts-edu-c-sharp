using efc02.Models;

namespace efc02.Services;

public class LoaiMonAnService : ILoaiMonAnService
{
    private CongThucNauAnDbContext _context;

    public LoaiMonAnService()
    {
        _context = new CongThucNauAnDbContext();
    }

    public void ThemLoaiMonAn(string tenLoaiMonAn)
    {
        bool isLoaiMonAn = _context.LoaiMonAn.Any(x => x.TenLoai == tenLoaiMonAn);

        if (isLoaiMonAn)
        {
            return;
        }

        LoaiMonAn loaiMonAn = new LoaiMonAn() { TenLoai = tenLoaiMonAn };

        _context.Add(loaiMonAn);
        _context.SaveChanges();
    }

    public int GetLoaiMonAnId(string tenLoaiMonAn)
    {
        int loaiMonAnId = _context
            .LoaiMonAn.Where(x => x.TenLoai == tenLoaiMonAn)
            .Select(x => x.LoaiMonAnId)
            .SingleOrDefault();

        return loaiMonAnId;
    }
}
