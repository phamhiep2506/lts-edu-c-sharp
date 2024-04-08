using System.ComponentModel.DataAnnotations;

namespace test_ef.Models;

public class ChiTietDonDatHang
{
    [Key]
    public int ChiTietDonDatHangId { get; set; }

    [Required]
    public int DonDatHangId { get; set; }

    [Required]
    public int SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public DonDatHang DonDatHang { get; set; } = null!;
    public SanPham SanPham { get; set; } = null!;
}
