using System.ComponentModel.DataAnnotations;

namespace test_ef.Models;

public class KhachHang
{
    [Key]
    public int KhachHangId { get; set; }

    [Required]
    [MaxLength(50)]
    public required string HoTen { get; set; }

    [Required]
    [MaxLength(100)]
    public required string DiaChi { get; set; }

    [MaxLength(15)]
    public string SoDienThoai { get; set; } = string.Empty;

    [MaxLength(100)]
    public string GhiChu { get; set; } = string.Empty;

    [MaxLength(20)]
    public string Email { get; set; } = string.Empty;

    public ICollection<DonDatHang> donDatHangs { get; } = new List<DonDatHang>();
}
