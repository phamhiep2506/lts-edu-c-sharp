class DanhBaController
{
    int id = 0;
    List<DanhBa> listDanhBa = new List<DanhBa>();

    public void ThemLienHe()
    {
        int soDienThoai;
        string tenLienHe;

        id = id + 1;
        soDienThoai = InputHelper.InputInt("Nhap So Dien Thoai: ");
        tenLienHe = InputHelper.InputString("Nhap Ten Lien He: ");

        DanhBa danhBa = new DanhBa();
        danhBa.ID = id;
        danhBa.SoDienThoai = soDienThoai;
        danhBa.TenLienHe = tenLienHe;
        danhBa.TrangThaiChan = false;

        listDanhBa.Add(danhBa);
    }

    public void ThayDoiTrangThaiChan()
    {
        int nhapID;
        bool success = false;
        nhapID = InputHelper.InputInt("Nhap ID: ");
        for(int i = 0; i < listDanhBa.Count; i++)
        {
            if (listDanhBa[i].ID == nhapID)
            {
                listDanhBa[i].TrangThaiChan = true;
                success = true;
            }
            else
            {
                success = false;
            }
        }

        if(!success)
        {
            Console.WriteLine("[?] Khong Ton Tai ID");
        }
    }

    public void DoiTenLienHe()
    {
        int nhapID;
        bool success = false;
        string tenLienHeMoi;
        nhapID = InputHelper.InputInt("Nhap ID: ");
        tenLienHeMoi = InputHelper.InputString("Nhap Ten Lien He Moi: ");
        for(int i = 0; i < listDanhBa.Count; i++)
        {
            if (listDanhBa[i].ID == nhapID)
            {
                listDanhBa[i].TenLienHe = tenLienHeMoi;
                success = true;
            } else
            {
                success = false;
            }
        }

        if(!success)
        {
            Console.WriteLine("[?] Khong Ton Tai ID");
        }
    }

    public void XoaLienHe()
    {
        int nhapID;
        bool success = false;
        nhapID = InputHelper.InputInt("Nhap ID: ");
        for(int i = 0; i < listDanhBa.Count; i++)
        {
            if (listDanhBa[i].ID == nhapID)
            {
                listDanhBa.Remove(listDanhBa[i]);
                success = true;
            }
            else
            {
                success = false;
            }
        }

        if(!success)
        {
            Console.WriteLine("[?] Khong Ton Tai ID");
        }
    }

    public void TimKiemTheoID()
    {
        int nhapID;
        bool success = false;
        nhapID = InputHelper.InputInt("Nhap ID: ");
        for(int i = 0; i < listDanhBa.Count; i++)
        {
            if (listDanhBa[i].ID == nhapID)
            {
                Console.WriteLine($"ID: {listDanhBa[i].ID}, Ten Lien He: {listDanhBa[i].TenLienHe}, So Lien He: {listDanhBa[i].SoDienThoai}, Trang Thai Chan: {listDanhBa[i].TrangThaiChan}");
                success = true;
            }
            else
            {
                success = false;
            }
        }

        if(!success)
        {
            Console.WriteLine("[?] Khong Ton Tai ID");
        }

    }
    public void XemDanhBa()
    {
        for(int i = 0; i < listDanhBa.Count; i++)
        {
            Console.WriteLine($"ID: {listDanhBa[i].ID}, Ten Lien He: {listDanhBa[i].TenLienHe}, So Lien He: {listDanhBa[i].SoDienThoai}, Trang Thai Chan: {listDanhBa[i].TrangThaiChan}");
        }

    }

}
