class SoNguyen
{
    public int GiaTri { get; set; }
    public bool LaSoChan { get; private set; }
    public bool LaNguyenTo {  get; private set; }
    public bool LaSoDoiXung { get; private set; }

    public void InThongTin()
    {
        string msgLaSoChan = (LaSoChan == true) ? "co" : "khong";
        string msgLaNguyenTo = (LaNguyenTo == true) ? "co" : "khong";

        Console.WriteLine($"So nguyen {GiaTri} {msgLaSoChan} la so chan, {msgLaNguyenTo} la so nguyen to");
    }
    
    public static int Cong(int a, int b)
    {
        return a + b;
    }

    private void KiemTraChan()
    {
        int giaTri = GiaTri;
        if(giaTri % 2 == 0)
        {
            LaSoChan = true;
        }
        else
        {
            LaSoChan = false;
        }
    }

    private void KiemTraNguyenTo()
    {
        int giaTri = GiaTri;
        if(giaTri < 2)
        {
            LaNguyenTo = false;
        }
        int count = 0;
        for(int i = 2; i <= Math.Sqrt(giaTri); i++)
        {
            if(giaTri % i == 0)
            {
                count++;
            }

        }
        if(count == 0)
        {
            LaNguyenTo = true;
        } else
        {
            LaNguyenTo = false;
        }
    }

    private void KiemTraDoiXung()
    {
        int giaTri = GiaTri;
        int giaTriReverse = 0, rem;
        while(giaTri != 0)
        {
            rem = giaTri % 10;
            giaTriReverse = giaTriReverse * 10 + rem;
            giaTri /= 10;
        }
        if (giaTri == giaTriReverse)
        {
            LaSoDoiXung = true;
        } else
        {
            LaSoDoiXung = false;
        }
    }

    public SoNguyen()
    {
        Console.Write("Nhap Gia Tri: ");
        GiaTri = Convert.ToInt32(Console.ReadLine());
        KiemTraChan();
        KiemTraNguyenTo();
        KiemTraDoiXung();
    }

    public SoNguyen(int GiaTri)
    {
        this.GiaTri = GiaTri;
        KiemTraChan();
        KiemTraNguyenTo();
        KiemTraDoiXung();
    }
}
