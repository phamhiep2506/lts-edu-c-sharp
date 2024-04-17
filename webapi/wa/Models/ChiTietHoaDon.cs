using System.ComponentModel.DataAnnotations;

namespace wa.Models;

public class ChiTietHoaDon
{
    [Key]
    public int ChiTietHoaDonId { get; set; }

    public int HoaDonId { get; set; }

    public int SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public string? DonViTinh { get; set; }

    public double ThanhTien { get; set; }

    public SanPham? SanPham { get; set; }

    public HoaDon? HoaDon { get; set; }
}
