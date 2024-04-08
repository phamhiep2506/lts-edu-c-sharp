using ef05.Models;

namespace ef05.Services;

public class LoaiMonAnService : ILoaiMonAnService
{
    private MonAnDbContext _context;
    public LoaiMonAnService()
    {
        _context = new MonAnDbContext();
    }

    public int GetLoaiMonAnId(string tenLoai)
    {
        int loaiMonAnId = _context
            .LoaiMonAn
            .Where(x => x.TenLoai == tenLoai)
            .Select(x => x.LoaiMonAnId)
            .SingleOrDefault();

        return loaiMonAnId;
    }
}