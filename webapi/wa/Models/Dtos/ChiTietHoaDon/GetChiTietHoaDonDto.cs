namespace wa.Models.Dtos.ChiTietHoaDon;

public class GetChiTietHoaDonDto
{
    public int ChiTietHoaDonId { get; set; }
    public string? TenSanPham { get; set; }
    public int SoLuong { get; set; }
    public string? DonViTinh { get; set; }
    public double ThanhTien { get; set; }
}
