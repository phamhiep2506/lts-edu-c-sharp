using System.ComponentModel.DataAnnotations;

namespace wa.Models;

public class SanPham
{
    [Key]
    public int SanPhamId { get; set; }

    public int LoaiSanPhamId { get; set; }

    [MaxLength(100)]
    public string? TenSanPham { get; set; }

    public double GiaThanh { get; set; }

    [MaxLength(100)]
    public string? MoTa { get; set; }

    public DateTime NgayHetHan { get; set; }

    [MaxLength(50)]
    public string? KyHieuSanPham { get; set; }

    public LoaiSanPham? LoaiSanPham { get; set; }

    public ICollection<ChiTietHoaDon>? ChiTietHoaDons { get; set; }
}
