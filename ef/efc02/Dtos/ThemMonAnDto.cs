namespace efc02.Dtos;

public class ThemMonAnDto
{
    public required string TenMon { get; set; }

    public required string TenLoai { get; set; }

    public required List<string> NguyenLieu { get; set; }

    public required int SoLuong { get; set; }

    public required string DonViTinh { get; set; }
}
