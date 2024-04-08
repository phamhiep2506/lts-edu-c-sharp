using System.ComponentModel.DataAnnotations;

namespace efc03.Models;

public class ChiTietPhieuNhap
{
    [Key]
    public int ChiTietPhieuNhapId { get; set; }

    [Required]
    public int VatTuId { get; set; }

    [Required]
    public int PhieuNhapId { get; set; }

    public int SoLuongNhap { get; set; }

    public PhieuNhap PhieuNhap { get; set; } = null!;
}
