namespace wa.Models.Dtos.SanPham;

public class GetSanPhamDto
{
    public string? TenSanPham { get; set; }
    public string? TenLoaiSanPham { get; set; }
    public double GiaThanh { get; set; }
    public string? MoTa { get; set; }
    public string? NgayHetHan { get; set; }
    public string? KyHieuSanPham { get; set; }
}
