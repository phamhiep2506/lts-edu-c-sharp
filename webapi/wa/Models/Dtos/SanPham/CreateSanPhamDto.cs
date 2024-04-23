using System.ComponentModel.DataAnnotations;

namespace wa.Models.Dtos.SanPham;

public class CreateSanPhamDto
{
    [MaxLength(50, ErrorMessage = "Tên sản phẩm không được quá 50 ký tự")]
    public string? TenSanPham { get; set; }

    [MaxLength(50, ErrorMessage = "Tên loại sản phẩm không được quá 50 ký tự")]
    public string? TenLoaiSanPham { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Giá thành không hợp lệ")]
    public double GiaThanh { get; set; }

    [MaxLength(100, ErrorMessage = "Tên loại sản phẩm không được quá 100 ký tự")]
    public string? MoTa { get; set; }

    [RegularExpression(@"(\d{2})\/(\d{2})\/(\d{4})", ErrorMessage = "Ngày hết hạn không hợp lệ")]
    public string? NgayHetHan { get; set; }

    [MaxLength(50, ErrorMessage = "Ký hiệu sản phẩm không được quá 50 ký tự")]
    public string? KyHieuSanPham { get; set; }
}
