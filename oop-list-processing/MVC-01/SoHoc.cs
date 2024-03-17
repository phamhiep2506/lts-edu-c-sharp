class SoHoc
{
    public int GiaTri { get; set; }
    public bool LaSoChan { get; set; }
    public bool LaSoNguyenTo { get; set; }
    public bool LaSoDoiXung { get; set; }

    public SoHoc(int giaTri)
    {
        GiaTri = giaTri;
        CheckLaSoChan();
        CheckLaSoNguyenTo();
        CheckLaSoDoiXung();
    }

    private void CheckLaSoChan()
    {
        if (GiaTri % 2 == 0)
        {
            LaSoChan = true;
        }
        else
        {
            LaSoChan = false;
        }
    }

    private void CheckLaSoNguyenTo()
    {
        if (GiaTri < 2)
        {
            LaSoNguyenTo = false;
            return;
        }
        int count = 0;
        for (int i = 2; i <= Math.Sqrt(GiaTri); i++)
        {
            if (GiaTri % i == 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            LaSoNguyenTo = true;
        }
        else
        {
            LaSoNguyenTo = false;
        }
    }

    private int TimSoDao(int giaTri)
    {
        int soDao = 0;
        int rem;
        while (giaTri != 0)
        {
            /* Lấy chữ số cuối của số nguyên sử dụng toán tử chia lấy dư */
            rem = giaTri % 10;
            /* Nhân số đảo với 10 và cộng với chữ số cuối */
            soDao = (soDao * 10) + rem;
            /* Xóa chữ số cuối bằng cách sử dụng toán tử chia lấy phần nguyên */
            giaTri = giaTri / 10;
        }
        return soDao;
    }

    private void CheckLaSoDoiXung()
    {
        if (GiaTri == TimSoDao(GiaTri))
        {
            LaSoDoiXung = true;
        }
        else
        {
            LaSoDoiXung = false;
        }
    }

    public void InThongTin()
    {
        string laSoChan = LaSoChan ? "co" : "khong";
        string laSoNguyenTo = LaSoNguyenTo ? "co" : "khong";
        string laSoDoiXung = LaSoDoiXung ? "co" : "khong";

        Console.WriteLine($"So co gia tri la {GiaTri}, {laSoChan} la so chan, {laSoNguyenTo} la so nguyen to, {laSoDoiXung} la so doi xung.");
    }
}
