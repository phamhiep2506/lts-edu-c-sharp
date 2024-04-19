using System.ComponentModel.DataAnnotations;

namespace wa.Models;

public class KhachHang
{
    [Key]
    public int KhachHangId { get; set; }

    [MaxLength(100)]
    public string? HoTen { get; set; }

    public DateTime NgaySinh { get; set; }

    [MaxLength(15)]
    public string? SoDienThoai { get; set; }

    public ICollection<HoaDon>? HoaDons { get; set; }
}
