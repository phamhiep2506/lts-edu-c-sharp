using ef02.Dto;

namespace ef02.IServices
{
    public interface INhanVienService
    {
        public void ThemNhanVien(NhanVienDto nhanVienDto);
        public void XoaNhanVien(XoaNhanVienDto xoaNhanVienDto);
        public int TinhLuongNhanVien(TinhLuongNhanVienDto tinhLuongNhanVienDto);
    }
}
