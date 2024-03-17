public enum LoaiSo
{
    BatKy,
    SoChan,
    SoLe,
    SoNguyenTo,
    SoDoiXung
}

class SoHocController
{
    public List<SoHoc> dsSoHoc = new List<SoHoc>();

    public int TaoSoNgauNhien()
    {
        Random rnd = new Random();
        return rnd.Next(1, 1000);
    }

    public void HienThi(LoaiSo loaiSo)
    {
        switch (loaiSo)
        {
            case LoaiSo.BatKy:
                dsSoHoc.ForEach((soHoc) =>
                {
                    soHoc.InThongTin();
                });
                break;
            case LoaiSo.SoChan:
                dsSoHoc.ForEach((soHoc) =>
                {
                    if (soHoc.LaSoChan)
                    {
                        soHoc.InThongTin();
                    }
                });
                break;
            case LoaiSo.SoLe:
                dsSoHoc.ForEach((soHoc) =>
                {
                    if (!soHoc.LaSoChan)
                    {
                        soHoc.InThongTin();
                    }
                });
                break;
            case LoaiSo.SoNguyenTo:
                dsSoHoc.ForEach((soHoc) =>
                {
                    if (soHoc.LaSoNguyenTo)
                    {
                        soHoc.InThongTin();
                    }
                });
                break;
            case LoaiSo.SoDoiXung:
                dsSoHoc.ForEach((soHoc) =>
                {
                    if (soHoc.LaSoDoiXung)
                    {
                        soHoc.InThongTin();
                    }
                });
                break;
            default:
                Environment.Exit(1);
                break;
        }
    }
}
