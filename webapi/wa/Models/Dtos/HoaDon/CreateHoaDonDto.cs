using System.ComponentModel.DataAnnotations;
using wa.Models.Dtos.ChiTietHoaDon;

namespace wa.Models.Dtos.HoaDon;

public class CreateHoaDonDto
{
    [MaxLength(50, ErrorMessage = "Tên khách hàng không được dài quá 50 kí tự")]
    public string? TenKhachHang { get; set; }

    [MaxLength(10, ErrorMessage = "Số điện thoại không được dài quá 12 kí tự")]
    [RegularExpression(
        @"(84|0[3|5|7|8|9])+([0-9]{8})",
        ErrorMessage = "Số điện thoại không hợp lệ"
    )]
    public string? SoDienThoai { get; set; }

    [MaxLength(50, ErrorMessage = "Tên hóa đơn không được dài quá 50 kí tự")]
    public string? TenHoaDon { get; set; }

    [MaxLength(100, ErrorMessage = "Ghi chú không được dài quá 100 kí tự")]
    public string? GhiChu { get; set; }

    public List<CreateChiTietHoaDonDto>? CreateChiTietHoaDons { get; set; }
}
