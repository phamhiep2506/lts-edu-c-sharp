using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_ef.Models;

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

    [MaxLength(50)]
    public string LaSanPhamMoi { get; set; } = string.Empty;

    public LoaiSanPham LoaiSanPham { get; set; } = null!;

    public ICollection<ChiTietDonDatHang> chiTietDonDatHangs { get; } = new List<ChiTietDonDatHang>();
}
