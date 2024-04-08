using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_rf.Models;

public class SanPham
{
    [Key]
    public int SanPhamId { get; set; }

    [Required]
    public int LoaiSanPhamId { get; set; }

    [MaxLength(50)]
    public string KyHieuSanPham { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string TenSanPham { get; set; } = string.Empty;

    [MaxLength(100)]
    public string MoTa { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string NhaSanXuat { get; set; } = string.Empty;

    [Required]
    public DateTime NgayDang { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal GiaBan { get; set; }

    [Column(TypeName = "bit")]
    public bool LaSanPhamMoi { get; set; }

    public LoaiSanPham LoaiSanPham { get; set; } = null!;
}