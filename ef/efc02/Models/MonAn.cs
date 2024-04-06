using System.ComponentModel.DataAnnotations;

namespace efc02.Models;

public class MonAn
{
    [Key]
    public int MonAnId { get; set; }

    [Required]
    [MinLength(1)]
    [MaxLength(50)]
    public string TenMon { get; set; } = string.Empty;

    public string GhiChu { get; set; } = string.Empty;

    [Required]
    public int LoaiMonAnId { get; set; }

    public LoaiMonAn LoaiMonAn { get; set; } = null!;
}
