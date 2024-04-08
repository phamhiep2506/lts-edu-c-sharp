namespace ef05.Dtos;

public class ThemCongThucDto
{
    public required string TenNguyenLieu { get; set; }
    public required string TenMonAn { get; set; }
    public int SoLuong { get; set; }
    public string DonViTinh { get; set; } = string.Empty;
}