namespace efc02.Dtos;

public class ThemNguyenLieuDto
{
    public required string TenNguyenLieu { get; set; }
    public int SoLuong { get; set; }
    public string DonViTinh { get; set; } = string.Empty;
}
