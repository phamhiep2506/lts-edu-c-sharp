using ef04.Dto;

namespace ef04.Services;

public interface INguyenLieuService
{
    public void ThemNguyenLieu(ThemNguyenLieuDto themNguyenLieuDto);

    public int GetNguyenLieuId(string tenNguyenLieu);
}
