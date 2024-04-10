using test_ef.Dtos;

namespace test_ef.IServices;

public interface ISanPhamService
{
    public List<ThongTinSanPhamDto> LayThongTinSanPham();
    public List<ThongTinSanPhamDateDto> LayThongTinSanPhamBanDuocNam2019();
    public List<ThongTinSanPhamDateDto> LaySanPhamTDoAnTrongNgay25052020();
    public List<SHDSanPhamSLDto> LaySanPhamTDoAnDoUong();
    public decimal LayTongTienTrongNgay25052020();
    public List<TongSoSanPhamTungHoaDonDto> LayTongSoSanPhamTungHoaDon();
    public ThongTinSanPhamDto LaySanPhamBanThapNhat2019();
    public List<ThongTinSanPhamDateDto> LaySanPhamBanRa09062020();
    public List<ThongTinSanPhamSLDto> LaySanPhamChiDat1Lan();
}
