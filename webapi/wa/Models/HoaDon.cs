using System.ComponentModel.DataAnnotations;

namespace wa.Models;

public class HoaDon
{
    [Key]
    public int HoaDonId { get; set; }

    public int KhachHangId { get; set; }

    [MaxLength(100)]
    public string? TenHoaDon { get; set; }

    [MaxLength(100)]
    public string? MaGiaoDich { get; set; }

    public DateTime ThoiGianTao { get; set; }

    public DateTime? ThoiGianCapNhap { get; set; }

    [MaxLength(100)]
    public string? GhiChu { get; set; }

    public double TongTien { get; set; }

    public KhachHang? KhachHang { get; set; }
    public ICollection<ChiTietHoaDon>? ChiTietHoaDons { get; set; }
}
