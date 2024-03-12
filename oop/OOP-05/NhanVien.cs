class NhanVien
{
    public int MaSinhVien { get; set; }
    public string HoVaTen { get; set; }
    public string PhongBan { get; set; }
    public string DiaChi {get; set;}
    public string SoDienThoai { get; set; }

    public NhanVien(int MaSinhVien, string HoVaTen, string PhongBan, string DiaChi, string SoDienThoai)
    {
        this.MaSinhVien = MaSinhVien;
        this.HoVaTen = HoVaTen;
        this.PhongBan = PhongBan;
        this.DiaChi = DiaChi;
        this.SoDienThoai = SoDienThoai;
    }

    public void InThongTin()
    {
        Console.WriteLine($"Nhan vien {HoVaTen} thuoc phong ban {PhongBan} co so dien thoai la {SoDienThoai}");
    }
}