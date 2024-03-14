class HocVien
{
    public int MaHocVien { get; set; }
    public string HoTen { get; set; }
    public string NgaySinh { get; set; }
    public string Ho {  get; }
    public double HocPhi { get; set; }
    public string Email { get; }

    public void InThongTin()
    {
        Console.WriteLine($"{MaHocVien} co ten {HoTen} co email la {Email}");
    }

    public HocVien()
    {
        Console.Write("Nhap Ma Hoc Vien: ");
        MaHocVien = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap Ho Ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap Ngay Sinh: ");
        NgaySinh = Console.ReadLine();

        string[] hoTen;
        hoTen = HoTen.Split(" ");
        Ho = hoTen[0];

        Email = HoTen + "@edusolution.com";
    }

    public HocVien(int MaHocVien, string HoTen, string NgaySinh)
    {
        this.MaHocVien= MaHocVien;
        this.HoTen = HoTen;
        this.NgaySinh = NgaySinh;

        string[] hoTen;
        hoTen = HoTen.Split(" ");
        Ho = hoTen[0];

        Email = HoTen + "@edusolution.com";
    }

    public static List<HocVien> TimKiemHocVien(string ten, List<HocVien> hocViens)
    {
       return hocViens.Where(x => x.HoTen.ToLower().Contains(ten.ToLower())).ToList();
    }
}
