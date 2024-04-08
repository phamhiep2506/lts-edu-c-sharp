using System.ComponentModel.DataAnnotations;

namespace efc03.Models;

public class VatTu
{
    [Key]
    public int VatTuId { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(1)]
    public required string TenVatTu { get; set; }

    public int SoLuongTon { get; set; }

    public ChiTietPhieuNhap ChiTietPhieuNhap { get; set; } = null!;
    public ChiTietPhieuXuat ChiTietPhieuXuat { get; set; } = null!;
}
