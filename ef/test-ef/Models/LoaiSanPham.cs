using System.ComponentModel.DataAnnotations;

namespace test_ef.Models;

public class LoaiSanPham
{
    [Required]
    public int LoaiSanPhamId { get; set; }

    [Required]
    [MaxLength(100)]
    public required string TenLoai { get; set; }

    [MaxLength(100)]
    public string GhiChu { get; set; } = string.Empty;

    public ICollection<SanPham> sanPhams = new List<SanPham>();
}
