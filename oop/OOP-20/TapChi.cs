class TapChi : TaiLieu
{
    public int SoPhatHanh { get; set; }
    public int ThangPhatHanh { get; set; }

    public override void InThongTinTaiLieu()
    {
        Console.WriteLine($"Ma tai lieu: {MaTaiLieu}");
        Console.WriteLine($"Ten nha san xuat: {TenNhaSanXuat}");
        Console.WriteLine($"So ban phat hanh: {SoBanPhatHanh}");
        Console.WriteLine($"Ten tai lieu: {TenTaiLieu}");
        Console.WriteLine($"So phat hanh: {SoPhatHanh}");
        Console.WriteLine($"Thang phat hanh: {ThangPhatHanh}");
    }

    public override void NhapThongTinTaiLieu()
    {
        Console.Write("Ma tai lieu: ");
        MaTaiLieu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ten nha san xuat: ");
        TenNhaSanXuat = Console.ReadLine();

        Console.Write("So ban phat hanh: ");
        SoBanPhatHanh = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ten tai lieu: ");
        TenTaiLieu = Console.ReadLine();

        Console.Write("So phat hanh: ");
        SoPhatHanh = Convert.ToInt32(Console.ReadLine());

        Console.Write("Thang phat hanh: ");
        ThangPhatHanh = Convert.ToInt32(Console.ReadLine());
    }
}
