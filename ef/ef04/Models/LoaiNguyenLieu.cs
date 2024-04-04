using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef04.Models;

public class LoaiNguyenLieu
{
    [Key]
    public int LoaiNguyenLieuId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(20)")]
    public string? TenLoai { get; set; }

    public string? MoTa { get; set; }

    public ICollection<NguyenLieu>? NguyenLieu { get; }
}
