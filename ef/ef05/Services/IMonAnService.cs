using ef05.Dtos;

namespace ef05.Services;

public interface IMonAnService
{
    public void ThemMonAn(ThemMonAnDto themMonAnDto);
    public void XoaMonAn(string tenMon);

    public int GetMonAnId(string tenMonAn);
}