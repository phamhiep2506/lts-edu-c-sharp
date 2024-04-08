namespace efc03.Dtos;

public class PhieuNhapDto
{
    public required int SoLuongNhap { get; set; }

    public required string TenVatTu { get; set; }

    public required int MaPhieu { get; set; }

    public string TieuDe { get; set; } = string.Empty;

}

