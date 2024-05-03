using System.ComponentModel.DataAnnotations;

namespace wa.Models.Dtos.KhachHang;

public class CreateKhachHangDto
{
    [MaxLength(50, ErrorMessage = "Tên không được dài quá 50 kí tự")]
    public string? HoTen { get; set; }

    [RegularExpression(
        @"(\d{2})\/(\d{2})\/(\d{4})",
        ErrorMessage = "Ngày sinh không hợp lệ"
    )]
    public string? NgaySinh { get; set; }

    [MaxLength(10, ErrorMessage = "Số điện thoại không được dài quá 12 kí tự")]
    [RegularExpression(
        @"(84|0[3|5|7|8|9])+([0-9]{8})",
        ErrorMessage = "Số điện thoại không hợp lệ"
    )]
    public string? SoDienThoai { get; set; }
}
