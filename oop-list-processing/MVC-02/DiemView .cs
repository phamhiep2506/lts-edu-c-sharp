class DiemView
{
    enum EMenu
    { 
        ThemHS,
        ThemMH,
        ChamDiem,
        XemBangDiem
    }

    public static void Menu()
    { 
        DiemController diemController = new DiemController();
        while(true)
        {
            Console.WriteLine("0. Them Hoc Sinh");
            Console.WriteLine("1. Them Mon Hoc");
            Console.WriteLine("2. Cham Diem");
            Console.WriteLine("3. Xem Bang Diem");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap: ");
            EMenu menu = (EMenu) Convert.ToInt32(Console.ReadLine());
            switch (menu)
            { 
                case EMenu.ThemHS:
                    diemController.ThemHS();
                    break;
                case EMenu.ThemMH:
                    diemController.ThemMonHoc();
                    break;
                case EMenu.ChamDiem:
                    diemController.ChamDiem();
                    break;
                case EMenu.XemBangDiem:
                    diemController.BangDiem();
                    break;
            }
        }
    }
}
