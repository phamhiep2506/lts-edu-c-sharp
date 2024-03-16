class Sach : TaiLieu
{
    public string TenTacGia { get; set; }
    public int SoTrang { get; set; }

    public override void InThongTinTaiLieu()
    {
        Console.WriteLine($"Ma tai lieu: {MaTaiLieu}");
        Console.WriteLine($"Ten nha san xuat: {TenNhaSanXuat}");
        Console.WriteLine($"So ban phat hanh: {SoBanPhatHanh}");
        Console.WriteLine($"Ten tai lieu: {TenTaiLieu}");
        Console.WriteLine($"Ten tac gia: {TenTacGia}");
        Console.WriteLine($"So Trang: {SoTrang}");
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

        Console.Write("Ten tac gia: ");
        TenTacGia = Console.ReadLine();

        Console.Write("So trang: ");
        SoTrang = Convert.ToInt32(Console.ReadLine());
    }
}
