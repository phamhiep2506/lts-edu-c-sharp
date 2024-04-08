using System.ComponentModel.DataAnnotations;

namespace efc03.Models;

public class PhieuNhap
{
    [Key]
    public int PhieuNhapId { get; set; }

    [Required]
    public int MaPhieu { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(1)]
    public string TieuDe { get; set; } = string.Empty;

    public DateTime NgayNhap { get; set; }
}
