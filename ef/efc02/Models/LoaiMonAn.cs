using System.ComponentModel.DataAnnotations;

namespace efc02.Models;

public class LoaiMonAn
{
    [Key]
    public int LoaiMonAnId { get; set; }

    [Required]
    [MinLength(1)]
    [MaxLength(50)]
    public string TenLoai { get; set; } = string.Empty;
}
