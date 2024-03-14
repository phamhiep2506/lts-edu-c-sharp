class HocSinh
{
    public string HoTen {get; set;}
    public string Lop {get; set;}
    public string NgaySinh {get; set;}
    public double DiemToan {get; set;}
    public double DiemVan {get; set;}
    public double DiemAnh {get; set;}
    public double DiemTrungBinh {get; set;}

    public HocSinh()
    {
        Console.Write("Nhap Ho Ten: ");
        HoTen = Convert.ToString(Console.ReadLine());
        Console.Write("Nhap Lop: ");
        Lop = Convert.ToString(Console.ReadLine());
        Console.Write("Nhap Ngay Sinh: ");
        NgaySinh = Convert.ToString(Console.ReadLine());
        Console.Write("Nhap Diem Toan: ");
        DiemToan = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap Diem Van: ");
        DiemVan = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap Diem Anh: ");
        DiemAnh = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap Diem Trung Binh: ");
        DiemTrungBinh = Convert.ToDouble(Console.ReadLine());
    }

    public HocSinh(string HoTen, string Lop, string NgaySinh, double DienToan, double DienVan, double DiemAnh, double DiemTrungBinh)
    {
        this.HoTen = HoTen;
        this.Lop = Lop;
        this.NgaySinh = NgaySinh;
        this.DiemToan = DiemToan;
        this.DiemVan = DiemVan;
        this.DiemAnh = DiemAnh;
        this.DiemTrungBinh = DiemTrungBinh;
    }

    public void InThongTin()
    {
        Console.WriteLine($"{HoTen} hoc o {Lop} co diem trung binh la {DiemTrungBinh}");
    }
}
