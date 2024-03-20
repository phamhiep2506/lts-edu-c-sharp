class Diem
{ 
    public int MaHS { get; set; }
    public int MaMH { get; set; }
    public double DiemMH { get; set; }

    public Diem()
    {
        MaHS = InputHelper.NhapSo("Nhap Ma Hoc Sinh: ");
        MaMH = InputHelper.NhapSo("Nhap Ma Mon Hoc: ");
        double diem = InputHelper.NhapDouble("Nhap Diem Mon Hoc: ");
        if (diem >= 0 && diem <= 10 || diem % 0.25 == 0)
        {
            DiemMH = diem;
        }
    }
}