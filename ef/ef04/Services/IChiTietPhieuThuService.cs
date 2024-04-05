using ef04.Dto;

namespace ef04.Services;

public interface IChiTietPhieuThuService
{
    public void ThemChiTietPhieuThu(ThemChiTietPhieuThuDto themChiTietPhieuThuDto, int phieuThuId);
}