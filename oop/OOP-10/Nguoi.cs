class Nguoi
{
    public int MaSo {get; set;}
    public string HoTen {get; set;}
    public string NgaySinh {get; set;}
    public string Ho {get;}
    public string Dem {get;}
    public string Ten {get;}

    public void InThongTin()
    {
        Console.WriteLine($"{MaSo} co ten la {HoTen} sinh ngay {NgaySinh}");
    }

    public Nguoi()
    {
        Console.Write("Nhap Ma So: ");
        MaSo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap Ho Ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap Ngay Sinh: ");
        NgaySinh = Console.ReadLine();
    }
    public Nguoi(int MaSo, string HoTen, string NgaySinh)
    {
        this.MaSo = MaSo;
        this.HoTen = HoTen;
        this.NgaySinh = NgaySinh;
    }
}
