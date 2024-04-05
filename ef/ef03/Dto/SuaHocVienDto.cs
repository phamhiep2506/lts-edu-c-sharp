namespace ef03.Dto;

public class SuaHocVienDto
{
    public string TenKhoaHoc { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;

    public DateTime NgaySinh { get; set; }

    public string QueQuan { get; set; } = string.Empty;

    public string DiaChi { get; set; } = string.Empty;

    public int SoDienThoai { get; set; }
}