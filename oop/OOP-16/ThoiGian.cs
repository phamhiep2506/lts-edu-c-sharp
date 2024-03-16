using System.Data;

class ThoiGian
{
    public int Ngay {get; set;}
    public int Thang {get; set;}
    public int Nam {get; set;}
    public bool LaNamNhuan {get;}
    public string Thu {get;}

    public void LayThongTin()
    {
        string msg = LaNamNhuan ? "co" : "khong";
        Console.WriteLine($"Thoi gian hien tai la: Thu {Thu}, ngay {Thang}, thang {Thang}, nam {Nam}");
        Console.WriteLine($"Day {msg} phai la nam nhuan");
    }

    private void NhapNgay()
    {
        Console.WriteLine("Nhap Ngay: ");
        Ngay = Convert.ToInt32(Console.ReadLine());
    }

    private void NhapThang()
    {
        Console.WriteLine("Nhap Thang: ");
        Thang = Convert.ToInt32(Console.ReadLine());
    }

    private void NhapNam()
    {
        Console.WriteLine("Nhap Nam: ");
        Nam = Convert.ToInt32(Console.ReadLine());
    }

    public ThoiGian()
    {
        NhapNgay();
        NhapThang();
        NhapNam();
        if((Nam % 4 == 0) && (Nam % 100 != 0) || (Nam % 400 == 0))
        {
            LaNamNhuan = true;
        }
        else
        {
            LaNamNhuan = false;
        }
        DateTime dateTime = DateTime.Now.AddDays(Ngay);
        Thu = dateTime.DayOfWeek.ToString();
    }

    public ThoiGian(int ngay, int thang, int nam)
    {
        Ngay = ngay;
        Thang = thang;
        Nam = nam;

        if((Nam % 4 == 0) && (Nam % 100 != 0) || (Nam % 400 == 0))
        {
            LaNamNhuan = true;
        }
        else
        {
            LaNamNhuan = false;
        }
        DateTime dateTime = DateTime.Now.AddDays(Ngay);
        Thu = dateTime.DayOfWeek.ToString();
    }

    public static void LayKhoangThoiGian(ThoiGian thoiGian1, ThoiGian thoiGian2)
    {
        DateTime dateTime1 = new DateTime(thoiGian1.Nam, thoiGian1.Thang, thoiGian1.Ngay);
        DateTime dateTime2 = new DateTime(thoiGian2.Nam, thoiGian2.Thang, thoiGian2.Ngay);
        TimeSpan time = dateTime2 - dateTime1;
        Console.WriteLine($"Khoang thoi gian giua 2 ngay {time.Days}");
    }

}
