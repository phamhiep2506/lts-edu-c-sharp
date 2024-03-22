class DanhBaView
{
    enum EMenu: int
    {
        XemDanhBa = 1,
        ThemLienHe = 2,
        ThayDoiTrangThaiChan = 3,
        DoiTenLienHe = 4,
        XoaLienHe = 5,
        TimKiemTheoID = 6
    }
    public static void Menu()
    {
        DanhBaController danhBaController = new DanhBaController();
        while (true)
        {
            Console.WriteLine("1. Xem Danh Ba");
            Console.WriteLine("2. Them Lien He");
            Console.WriteLine("3. Thay Doi Trang Thai Chan");
            Console.WriteLine("4. Doi Ten Lien He");
            Console.WriteLine("5. Xoa Lien He");
            Console.WriteLine("6. Tim Kiem Theo ID");
            Console.WriteLine("7. Thoat");
            Console.Write("Chon tuy chon (1/2/3/4/5/6/7): ");
            EMenu eMenu = (EMenu) Convert.ToInt32(Console.ReadLine());
            switch(eMenu)
            {
                case EMenu.XemDanhBa:
                    danhBaController.XemDanhBa();
                    break;
                case EMenu.ThemLienHe:
                    danhBaController.ThemLienHe();
                    break;
                case EMenu.ThayDoiTrangThaiChan:
                    danhBaController.ThayDoiTrangThaiChan();
                    break;
                case EMenu.DoiTenLienHe:
                    danhBaController.DoiTenLienHe();
                    break;
                case EMenu.XoaLienHe:
                    danhBaController.XoaLienHe();
                    break;
                case EMenu.TimKiemTheoID:
                    danhBaController.TimKiemTheoID();
                    break;
                default:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
