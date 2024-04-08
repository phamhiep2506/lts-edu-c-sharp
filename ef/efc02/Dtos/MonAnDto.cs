namespace efc02.Dtos;

public class MonAnDto
{
    public required string TenMonAn { get; set; }
    public required string TenNguyenLieu { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public string DonViTinh { get; set; } = string.Empty;
}