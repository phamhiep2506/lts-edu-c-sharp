class MonHoc
{
    public int MaMH { get; set; }
    public string TenMH { get; set; }
    public int SoTiet { get; set; }

    public MonHoc()
    { 
        MaMH = InputHelper.NhapSo("Nhap Ma Mon Hoc: ");
        TenMH = InputHelper.NhapChuoi("Nhap Ten Mon Hoc: ");
        SoTiet = InputHelper.NhapSo("Nhap So Tiet: ");
    }

    public void InThongTin()
    {
        Console.WriteLine($"Ma mon hoc {MaMH}, Ten mon hoc {TenMH}, So tiet {SoTiet}");
    }
}
