using System.ComponentModel.DataAnnotations;

namespace wa.Models.Dtos.ChiTietHoaDon;

public class UpdateChiTietHoaDonDto
{
    public int SanPhamId { get; set; }

    [MaxLength(50, ErrorMessage = "Tên sản phẩm không được quá 50 ký tự")]
    public string? TenSanPham { get; set; }

    public int SoLuong { get; set; }

    [MaxLength(50, ErrorMessage = "Đơn vị tính không được quá 50 ký tự")]
    public string? DonViTinh { get; set; }
}
