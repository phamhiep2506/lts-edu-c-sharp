using efc02.Dtos;

namespace efc02.Services;

public interface IMonAnService
{
    public void ThemMonAn(ThemMonAnDto themMonAnDto);
    public int GetMonAnId(string tenMon);
}
