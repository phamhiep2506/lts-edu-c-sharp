using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef03.Models;

public class KhoaHoc
{
    [Key]
    public int KhoaHocId { get; set; }

    [Column(TypeName = "nvarchar")]
    [MaxLength(10)]
    [Required]
    public required string TenKhoaHoc { get; set; }

    public string? MoTa { get; set; }

    [MaxLength(10000000)]
    public int HocPhi { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    ICollection<NgayHoc>? NgayHocs { get; set; }
    ICollection<HocVien>? HocViens { get; set; }
}
