class HoDan
{
    public int SoThanhVien { get; set; }
    public List<Nguoi> ThanhViens { get; set; } = new List<Nguoi>();
    public int SoNha { get; set; }

    public void NhapThanhVien()
    {
        for (int i = 0; i < SoThanhVien; i++)
        {
            ThanhViens.Add(new Nguoi());
        }
    }

    public HoDan(int soThanhVien, int soNha)
    {
        this.SoThanhVien = soThanhVien;
        this.SoNha = soNha;
        NhapThanhVien();
    }

    public void InThongTinHoDan()
    {
        Console.WriteLine($"Ho dan co so nha la {SoNha}");
        foreach (Nguoi nguoi in ThanhViens)
        {
            nguoi.InThongTin();
        }
    }
}
