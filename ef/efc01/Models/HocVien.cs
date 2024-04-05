using System.ComponentModel.DataAnnotations;

namespace efc01.Models;

public class HocVien
{
    [Key]
    public int HocVienId { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(50)]
    public string HoTen { get; set; } = string.Empty;

    [Required]
    public DateTime Ngaysinh { get; set; }

    [Required]
    public string GioiTinh { get; set; } = string.Empty;

    [Required]
    [MinLength(10)]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MinLength(10)]
    [MaxLength(15)]
    public string SoDienThoai { get; set; } = string.Empty;

    public string DiaChi { get; set; } = string.Empty;

    public string TrinhDo { get; set; } = string.Empty;

    public string Lop { get; set; } = string.Empty;

    public DateTime NgayDangKy { get; set; }
}
