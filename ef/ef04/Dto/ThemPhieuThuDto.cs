namespace ef04.Dto;

public class ThemPhieuThuDto
{
    public required string NhanVienLap { get; set; }

    public required decimal ThanhTien { get; set; }

    public required List<ThemChiTietPhieuThuDto> ThemChiTietPhieuThuDtos { get; set; }
}
