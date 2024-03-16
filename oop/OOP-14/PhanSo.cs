class PhanSo
{
    public int TuSo {get; set;}
    public int MauSo {get; set;}

    public void InThongSo()
    {
        Console.WriteLine($"Phan so la {TuSo}/{MauSo}");
    }

    public static int UCLN(int a, int b)
    {
        if(a % b != 0)
        {
            return UCLN(b, a % b);
        }
        else
        {
            return b;
        }
    }

    private void ToiGian()
    {
        int ucln = UCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;
        if(MauSo < 0)
        {
            MauSo *= -1;
            TuSo *= -1;
        }
    }

    public PhanSo(int TuSo, int MauSo)
    {
        this.TuSo = TuSo;
        this.MauSo = MauSo;
        ToiGian();
    }

    public static string Cong(PhanSo phanSo1, PhanSo phanSo2)
    {
        int Tu, Mau;
        Tu = phanSo1.TuSo * phanSo2.MauSo + phanSo1.MauSo * phanSo2.TuSo;
        Mau = phanSo1.MauSo * phanSo2.MauSo;

        int ucln = UCLN(Tu, Mau);
        Tu /= ucln;
        Mau /= ucln;
        if(Mau < 0)
        {
            Mau *= -1;
            Tu *= -1;
        }

        return $"{Tu}/{Mau}";
    }

    public static string Tru(PhanSo phanSo1, PhanSo phanSo2)
    {
        int Tu, Mau;
        Tu = phanSo1.TuSo * phanSo2.MauSo - phanSo1.MauSo * phanSo2.TuSo;
        Mau = phanSo1.MauSo * phanSo2.MauSo;

        int ucln = UCLN(Tu, Mau);
        Tu /= ucln;
        Mau /= ucln;
        if(Mau < 0)
        {
            Mau *= -1;
            Tu *= -1;
        }

        return $"{Tu}/{Mau}";
    }
}
