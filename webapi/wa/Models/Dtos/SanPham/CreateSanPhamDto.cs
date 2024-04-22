namespace wa.Models.Dtos.SanPham;

public class CreateSanPhamDto
{
    public int LoaiSanPhamId { get; set; }
    public string? TenSanPham { get; set; }
    public double GiaThanh { get; set; }
    public string? MoTa { get; set; }
    public DateTime NgayHetHan { get; set; }
    public string? KyHieuSanPham { get; set; }
}
