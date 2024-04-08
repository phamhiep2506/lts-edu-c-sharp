using System.ComponentModel.DataAnnotations;

namespace test_rf.Models;

public class DonDatHang
{
    [Key]
    public int DonDatHangId { get; set; }

    [Required]
    public int KhachHangId { get; set; }

    public int SoHieuDon { get; set; }

    public DateTime NgayDat { get; set; }

    public DateTime NgayGioTraThucTe { get; set; }

    [MaxLength(100)]
    public string GhiChu { get; set; } = string.Empty;

    [MaxLength(10)]
    public string TinhTrang { get; set; } = string.Empty;

    public KhachHang KhachHang { get; set; } = null!;
}