using efc01.Dto;

namespace efc01.IServices;

public interface IHocVienService
{
    public void ThemHocVien(ThemHocVienDto themHocVienDto);
    public void CapNhatHocVien(CapNhatHocVienDto capNhatHocVien);
    public void XoaHocVien(XoaHocVienDto xoaHocVienDto);
    public List<HocVienDto> HienThiHocVien();
}
