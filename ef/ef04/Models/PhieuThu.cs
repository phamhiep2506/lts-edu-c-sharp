using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef04.Models;

public class PhieuThu
{
    [Key]
    public int PhieuThuId { get; set; }

    public DateTime NgayLap { get; set; }

    public string? NhanVienLap { get; set; }

    public string? GhiChu { get; set; }

    [Column(TypeName = "money")]
    public decimal ThanhTien { get; set; }

    public ICollection<ChiTietPhieuThu>? ChiTietPhieuThus { get; }
}
