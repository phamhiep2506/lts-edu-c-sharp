class Program
{
    public static void Main(string[] args)
    {
        List<TaiLieu> taiLieus = new List<TaiLieu>();
        IEnumerable<TaiLieu> duLieuTimKiem;
        string tuTimKiem;

        Console.WriteLine("Nhap sach");
        Sach sach = new Sach();
        sach.NhapThongTinTaiLieu();

        Console.WriteLine("Nhap tap chi");
        TapChi tapChi = new TapChi();
        tapChi.NhapThongTinTaiLieu();

        Console.WriteLine("Nhap truyen tranh");
        TruyenTranh truyenTranh = new TruyenTranh();
        truyenTranh.NhapThongTinTaiLieu();

        // In thong tin
        /* sach.InThongTinTaiLieu(); */
        /* tapChi.InThongTinTaiLieu(); */
        /* truyenTranh.InThongTinTaiLieu(); */

        // Add taiLieus
        taiLieus.Add(sach);
        taiLieus.Add(tapChi);
        taiLieus.Add(truyenTranh);

        // Tim kiem
        Console.Write("Tim kiem tai lieu: ");
        tuTimKiem = Console.ReadLine();

        duLieuTimKiem = TaiLieu.TimKiemTaiLieu(taiLieus, tuTimKiem);

        foreach(TaiLieu taiLieu in duLieuTimKiem)
        {
            taiLieu.InThongTinTaiLieu();
        }
    }
}
