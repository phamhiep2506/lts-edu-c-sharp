using efc02.Dtos;
using efc02.Models;

namespace efc02.Services;

public class MonAnService : IMonAnService
{
    private CongThucNauAnDbContext _context;

    public MonAnService()
    {
        _context = new CongThucNauAnDbContext();
    }

    public void ThemMonAn(ThemMonAnDto themMonAnDto)
    {
    }
}
