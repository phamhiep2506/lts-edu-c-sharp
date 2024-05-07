using System.ComponentModel.DataAnnotations;

namespace wa.Models.Dtos.ChiTietHoaDon;

public class UpdateChiTietHoaDonDto
{
    [Required]
    public int ChiTietHoaDonId { get; set; }

    [Required]
    public int SanPhamId { get; set; }

    [Required]
    public int SoLuong { get; set; }

    public string? DonViTinh { get; set; }
}
