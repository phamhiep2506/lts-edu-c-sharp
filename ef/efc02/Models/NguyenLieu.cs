using System.ComponentModel.DataAnnotations;

namespace efc02.Models;

public class NguyenLieu
{
    [Key]
    public int NguyenLieuId { get; set; }

    [Required]
    [MinLength(1)]
    [MaxLength(50)]
    public string TenNguyenLieu { get; set; } = string.Empty;
}
