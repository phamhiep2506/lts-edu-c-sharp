using System.ComponentModel.DataAnnotations;

namespace efc03.Models;

public class ChiTietPhieuXuat
{
    [Key]
    public int ChiTietPhieuXuatId { get; set; }

    [Required]
    public int VatTuId { get; set; }

    [Required]
    public int PhieuXuatId { get; set; }

    public int SoLuongXuat { get; set; }

    public PhieuXuat PhieuXuat { get; set; } = null!;
}
