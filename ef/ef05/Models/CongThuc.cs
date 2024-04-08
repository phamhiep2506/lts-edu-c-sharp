using System.ComponentModel.DataAnnotations;

namespace ef05.Models;

public class CongThuc
{
    [Key]
    public int CongThucId { get; set; }

    [Required]
    public int NguyenLieuId { get; set; }

    [Required]
    public int MonAnId { get; set; }

    public int SoLuong { get; set; }

    [MaxLength(100)]
    [MinLength(1)]
    public string DonViTinh { get; set; } = string.Empty;

    public NguyenLieu NguyenLieu { get; set; } = null!;
    public MonAn MonAn { get; set; } = null!;
}