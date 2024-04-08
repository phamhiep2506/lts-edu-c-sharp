namespace efc02.Dtos;

public class ThemMonAnDto
{
    public required string TenMon { get; set; }

    public required string TenLoai { get; set; }

    public required List<ThemNguyenLieuDto> ThemNguyenLieuDtos { get; set; }
}
