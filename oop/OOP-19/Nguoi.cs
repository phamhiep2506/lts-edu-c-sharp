class Nguoi
{
    public int CMND { get; set; }
    public string HoVaTen { get; set; }
    public int NamSinh { get; set; }
    public string NgheNghiep { get; set; }

    public Nguoi()
    {
        Console.Write("Nhap CNND: ");
        CMND = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap Ho Va Ten: ");
        HoVaTen = Console.ReadLine();

        Console.Write("Nhap Nam Sinh: ");
        NamSinh = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap Nghe Nghiep: ");
        NgheNghiep = Console.ReadLine();
    }

    public void InThongTin()
    {
        Console.WriteLine($"{HoVaTen} co CMND la {CMND}, nam sinh {NamSinh}, nghe nghiep {NgheNghiep}");
    }
}
