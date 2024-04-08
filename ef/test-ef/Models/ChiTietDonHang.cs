using System.ComponentModel.DataAnnotations;

namespace test_rf.Models;

public class ChiTietDonHang
{
    [Key]
    public int ChiTietDonHangId { get; set; }

    [Required]
    public int DonDatHangId { get; set; }

    [Required]
    public int SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public DonDatHang DonDatHang { get; set; } = null!;
    public SanPham SanPham { get; set; } = null!;
}