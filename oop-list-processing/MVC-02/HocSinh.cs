class HocSinh
{
    public int MaHocSinh { get; set; }
    public string TenHocSinh { get; set; }
    public DateTime NgaySinh { get; set; }

    public HocSinh()
    {
        MaHocSinh = InputHelper.NhapSo("Nhap Ma Hoc Sinh: ");
        TenHocSinh = InputHelper.NhapChuoi("Nhap Ten Hoc Sinh: ");
        NgaySinh = InputHelper.NhapDate("Nhap Ngay Sinh: ");
    }

    public void InThongTin()
    {
        Console.WriteLine($"Hoc sinh co ten {TenHocSinh}, ma hoc sinh {MaHocSinh}, ngay sinh {NgaySinh.ToString("dd/MM/yyyy")}");
    }
}
