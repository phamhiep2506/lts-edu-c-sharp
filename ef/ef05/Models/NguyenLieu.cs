using System.ComponentModel.DataAnnotations;

namespace ef05.Models;

public class NguyenLieu
{
    [Key]
    public int NguyenLieuId { get; set; }

    [MaxLength(100)]
    [MinLength(1)]
    public string TenNguyenLieu { get; set; } = string.Empty;

    [MaxLength(100)]
    [MinLength(1)]
    public string GhiChu {get; set; } = string.Empty;
}