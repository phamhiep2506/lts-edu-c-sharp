using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef05.Models;

public class MonAn
{
    [Key]
    public int MonAnId { get; set; }

    [Required]
    public int LoaiMonAnId { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(1)]
    public required string TenMon { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal GiaBan { get; set; }

    [MaxLength(100)]
    [MinLength(1)]
    public string GioiThieu { get; set; } = string.Empty;

    [MaxLength(100)]
    [MinLength(1)]
    public string CachLam { get; set; } = string.Empty;

    public LoaiMonAn LoaiMonAn { get; set; } = null!;
}