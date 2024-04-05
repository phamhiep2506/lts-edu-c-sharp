using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef03.Models;

public class HocVien
{
    [Key]
    public int HocVienId { get; set; }

    [Required]
    public int KhoaHocId { get; set; }

    [Column(TypeName = "nvarchar")]
    [MaxLength(20)]
    [MinLength(2)]
    [Required]
    public string? HoTen { get; set; }

    public DateTime NgaySinh { get; set; }

    public string? QueQuan { get; set; }

    public string? DiaChi { get; set; }

    public int SoDienThoai { get; set; }

    public virtual KhoaHoc? KhoaHoc { get; set; }
}
