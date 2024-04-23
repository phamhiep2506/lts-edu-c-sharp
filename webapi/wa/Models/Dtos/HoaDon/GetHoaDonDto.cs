using wa.Models.Dtos.ChiTietHoaDon;

namespace wa.Models.Dtos.HoaDon;

public class GetHoaDonDto
{
    public string? TenKhachHang { get; set; }
    public string? SoDienThoai { get; set; }
    public string? TenHoaDon { get; set; }
    public string? MaGiaoDich { get; set; }
    public string? ThoiGianTao { get; set; }
    public string? ThoiGianCapNhat { get; set; }
    public string? GhiChu { get; set; }
    public double TongTien { get; set; }
    List<GetChiTietHoaDonDto>? GetChiTietHoaDonDtos { get; set; }
}
