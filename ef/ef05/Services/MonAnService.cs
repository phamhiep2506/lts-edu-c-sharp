using ef05.Dtos;
using ef05.Models;

namespace ef05.Services;

public class MonAnService : IMonAnService
{
    private MonAnDbContext _context;
    public MonAnService()
    {
        _context = new MonAnDbContext();
    }

    public void ThemMonAn(ThemMonAnDto themMonAnDto)
    {
        MonAn monAn = new MonAn()
        {
            LoaiMonAnId = new LoaiMonAnService().GetLoaiMonAnId(themMonAnDto.TenLoai),
            TenMon = themMonAnDto.TenMon,
            GiaBan = themMonAnDto.GiaBan
        };
        _context.Add(monAn);
        _context.SaveChanges();
    }

    public void XoaMonAn(string tenMon)
    {
        MonAn? monAn = _context
            .MonAn?
            .Where(x => x.TenMon == tenMon)
            .SingleOrDefault();
        if(monAn == null)
        {
           return; 
        }
        _context.Remove(monAn);
        _context.SaveChanges();
    }

    public int GetMonAnId(string tenMonAn)
    {
        int monAnId = _context
            .MonAn
            .Where(x => x.TenMon == tenMonAn)
            .Select(x => x.MonAnId)
            .SingleOrDefault();

        return monAnId;
    }
}