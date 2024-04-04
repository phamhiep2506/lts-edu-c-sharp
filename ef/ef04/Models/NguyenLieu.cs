using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef04.Models;

public class NguyenLieu
{
    [Key]
    public int NguyenLieuId { get; set; }

    [Required]
    public int LoaiNguyenLieuId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(20)")]
    public string? TenNguyenLieu { get; set; }

    [Required]
    [Column(TypeName = "money")]
    public decimal GiaBan { get; set; }

    [Column(TypeName = "nvarchar(10)")]
    public string? DonViTinh { get; set; }

    public int SoLuongKho { get; set; }

    public ICollection<ChiTietPhieuThu>? ChiTietPhieuThus { get; }
    public virtual LoaiNguyenLieu? LoaiNguyenLieu { get; set; }

}
