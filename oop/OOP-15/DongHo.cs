class DongHo
{
    public int Gio {get; set;}
    public int Phut {get; set;}
    public int Giay {get; set;}
    public bool LaBuoiSang {get;}

    public void LayThongTin()
    {
        string msg = LaBuoiSang ? "sang" : "chieu";
        Console.WriteLine($"{Gio}:{Phut}:{Giay}");
        Console.WriteLine($"Bay gio la buoi {msg}");
    }

    private void NhapGio()
    {
        Console.Write("Nhap gio: ");
        Gio = Convert.ToInt32(Console.ReadLine());
    }

    private void NhapPhut()
    {
        Console.Write("Nhap phut: ");
        Phut = Convert.ToInt32(Console.ReadLine());
    }

    private void NhapGiay()
    {
        Console.Write("Nhap giay: ");
        Giay = Convert.ToInt32(Console.ReadLine());
    }

    public DongHo(int gio, int phut, int giay)
    {
        Gio = gio;
        Phut = phut;
        Giay = giay;
        if(Gio < 12) {
            LaBuoiSang = true;
        } else {
            LaBuoiSang = false;
        }
    }

    public DongHo()
    {
        NhapGio();
        NhapPhut();
        NhapGiay();
        if(Gio < 12) {
            LaBuoiSang = true;
        } else {
            LaBuoiSang = false;
        }
    }

}
