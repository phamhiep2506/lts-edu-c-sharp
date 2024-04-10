using test_ef.Dtos;

namespace test_ef.IServices;

public interface IKhachHangService
{
    public string LayKhachHangMuaNhieuNhat();
    public List<KhachHangDto> LayKhachHangMuaSanPhamHaNoi();
    public List<KhachHangSLDto> LayKhachHangDatTren100SP();
}
