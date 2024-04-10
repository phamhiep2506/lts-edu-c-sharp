using test_ef.Dtos;

namespace test_ef.IServices;

public interface IDonHangService
{
    public List<DonHangIdSanPhamDto> Lay3SanPhamDoVietNamSX();
    public int LayThang2019DanhSoCao();
    public decimal LayGiaTriHoaDonCaoNhat();
    public decimal LayGiaTriHoaDonThapNhat();
    public List<int> LayHoaDon3LoaiSP();
}
