using ef04.Dto;

namespace ef04.Services;

public interface IPhieuThuService
{
    public void ThemPhieuThu(ThemPhieuThuDto themPhieuThuDto);

    public void XoaPhieuThu(XoaPhieuThuDto xoaPhieuThuDto);
}
