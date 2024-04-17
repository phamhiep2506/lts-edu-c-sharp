namespace wa.Dtos.HoaDon;

public class AddHoaDonDto
{
    public int KhachHangId { get; set; }
    public string? TenHoaDon { get; set; }
    public string? MaGiaoDich { get; set; }
    public DateTime ThoiGianTao { get; set; }
    public DateTime? ThoiGianCapNhap { get; set; }
    public string? GhiChu { get; set; }
    public double TongTien { get; set; }
}
