using System.ComponentModel.DataAnnotations;

namespace wa.Models;

public class LoaiSanPham
{
    [Key]
    public int LoaiSanPhamId { get; set; }

    [MaxLength(100)]
    public string? TenLoaiSanPham { get; set; }

    public ICollection<SanPham>? SanPhams { get; set; }
}
