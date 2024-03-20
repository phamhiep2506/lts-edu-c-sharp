class DiemController
{

    public List<Diem> diem = new List<Diem>();
    public List<HocSinh> hocSinh = new List<HocSinh>();
    public List<MonHoc> monHoc = new List<MonHoc>();

    public void ThemHS()
    {
        HocSinh newHocSinh = new HocSinh();
        foreach (HocSinh hs in hocSinh)
        {
            if (hs.MaHocSinh == newHocSinh.MaHocSinh)
            {
                InputHelper.InErrorType(InputHelper.ErrorType.HSDaTonTai);
            } else
            {
                hocSinh.Add(newHocSinh);
                InputHelper.InErrorType(InputHelper.ErrorType.ThanhCong);
            }
        }
    }

    public void ThemMonHoc()
    {
        MonHoc newMonHoc = new MonHoc();
        foreach(MonHoc mh in monHoc)
        {
            if(mh.MaMH == newMonHoc.MaMH)
            {
                InputHelper.InErrorType(InputHelper.ErrorType.HSDaTonTai);
            }
            else
            {
                monHoc.Add(newMonHoc);
                InputHelper.InErrorType(InputHelper.ErrorType.ThanhCong);
            }
        }
    }

    public void ChamDiem()
    {
        int maHocSinh = InputHelper.NhapSo("Nhap Ma Hoc Sinh: ");
        int maMonHoc = InputHelper.NhapSo("Nhap Ma Mon Hoc: ");
        foreach (Diem d in diem)
        {
            if (d.MaMH == maHocSinh && d.MaMH == maMonHoc)
            {
                d.DiemMH = InputHelper.NhapDouble("Nhap Diem: ");
            }
        }
    }

    public void BangDiem()
    {
        int maHocSinh = InputHelper.NhapSo("Nhap Ma Hoc Sinh: ");
        foreach (Diem d in diem)
        {
            if (d.MaMH == maHocSinh)
            {
                Console.WriteLine($"Hoc sinh {d.MaMH}, Mon hoc {d.MaMH}, Diem {d.DiemMH}");
            }
        }
    }
}