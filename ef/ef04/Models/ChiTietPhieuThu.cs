using System.ComponentModel.DataAnnotations;

namespace ef04.Models;

public class ChiTietPhieuThu
{
    [Key]
    public int ChiTietPhieuThuId { get; set; }

    [Required]
    public int NguyenLieuId { get; set; }

    [Required]
    public int PhieuThuId { get; set; }

    public int SoLuongBan { get; set; }

    public virtual PhieuThu? PhieuThu { get; set; }
    public virtual NguyenLieu? NguyenLieu { get; set; }
}
