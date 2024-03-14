class LopHoc {
    public int MaLop {get; set;}
    public string TenLop {get; set;}
    public int SiSo {get; set;}
    public string DiaChi {get; set;}
    public string GVCN {get; set;}

    public LopHoc(int MaLop, string TenLop, int SiSo, string DiaChi, string GVCN)
    {
        this.MaLop = MaLop;
        this.TenLop = TenLop;
        this.SiSo = SiSo;
        this.DiaChi = DiaChi;
        this.GVCN = GVCN;
    }

    public void InThongTin()
    {
        Console.WriteLine($"Lop {TenLop} co ma la {MaLop} o {DiaChi}");
        Console.WriteLine($"Lop co {SiSo} hoc sinh va co GVCN la {GVCN}");
    }
}
