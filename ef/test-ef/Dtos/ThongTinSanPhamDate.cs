using System.ComponentModel.DataAnnotations;

namespace test_ef.Dtos;

public class ThongTinSanPhamDate
{
    public string TenSanPham { get; set; } = string.Empty;
    public string TenLoai { get; set; } = string.Empty;
    public DateTime NgayDat { get; set; }
}
