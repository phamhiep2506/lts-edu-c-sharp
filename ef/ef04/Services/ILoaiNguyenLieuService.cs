using ef04.Dto;

namespace ef04.Services;

public interface ILoaiNguyenLieuService
{
    public void ThemLoaiNguyenLieu(ThemLoaiNguyenLieuDto themLoaiNguyenLieuDto);

    public int GetLoaiNguyenLieuId(ThemLoaiNguyenLieuDto themLoaiNguyenLieuDto);
}
