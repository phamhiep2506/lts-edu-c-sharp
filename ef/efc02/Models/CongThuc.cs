using System.ComponentModel.DataAnnotations;

namespace efc02.Models;

public class CongThuc
{
    [Key]
    public int CongThucId { get; set; }

    [Required]
    public int MonAnId { get; set; }

    [Required]
    public int NguyenLieuId { get; set; }

    public int SoLuong { get; set; }

    public string DonViTinh { get; set; } = string.Empty;

    public NguyenLieu NguyenLieu { get; set; } = null!;
    public MonAn MonAn { get; set; } = null!;
}
