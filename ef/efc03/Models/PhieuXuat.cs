using System.ComponentModel.DataAnnotations;

namespace efc03.Models;

public class PhieuXuat
{
    [Key]
    public int PhieuXuatId { get; set; }

    [Required]
    public int MaPhieu { get; set;}

    [Required]
    [MaxLength(100)]
    [MinLength(1)]
    public string TieuDe { get; set; } = string.Empty;

    public DateTime NgayXuat { get; set; }
}
