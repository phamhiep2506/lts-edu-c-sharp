namespace efc01.Dto;

public class CapNhatHocVienDto
{
    public required string HoTen { get; set; }
    public required DateTime NgaySinh { get; set; }
    public required string GioiTinh { get; set; }
    public required string Email { get; set; }
    public required string SoDienThoai { get; set; }
    public string DiaChi { get; set; } = string.Empty;
    public string TrinhDo { get; set; } = string.Empty;
    public string Lop { get; set; } = string.Empty;
    public DateTime NgayDangKy { get; set; }
}
