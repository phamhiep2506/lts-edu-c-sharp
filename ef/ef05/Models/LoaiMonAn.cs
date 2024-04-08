using System.ComponentModel.DataAnnotations;

namespace ef05.Models;

public class LoaiMonAn
{
    [Key]
    public int LoaiMonAnId { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(1)]
    public required string TenLoai { get; set; }

    [MaxLength(100)]
    [MinLength(1)]
    public string MoTa { get; set; } = string.Empty;
}