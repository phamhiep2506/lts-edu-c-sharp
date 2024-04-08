using test_ef.Dtos;

namespace test_ef.IServices;

public interface ISanPhamService
{
    public List<ThongTinSanPham> LayThongTinSanPham();
    public List<ThongTinSanPhamDate> LayThongTinSanPhamKhongBanDuocNam2019();
    public List<ThongTinSanPhamDate> LaySanPhamTDoAnTrongNgay25052020();
    public List<SHDSanPhamSL> LaySanPhamTDoAnDoUong();
    public decimal LayTongTienTrongNgay25052020();
}
