class SoHocView
{
    private int n;
    public void Menu()
    {
        SoHocController soHocController = new SoHocController();

        /* Nhap so */
        Console.Write("Nhap so can tao ngau nhien: ");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            SoHoc soHoc = new SoHoc(soHocController.TaoSoNgauNhien());
            soHocController.dsSoHoc.Add(soHoc);
        }

        /* Print */
        while(true)
        {
            Console.WriteLine("0. Hien thi tat ca");
            Console.WriteLine("1. Hien thi so chan");
            Console.WriteLine("2. Hien thi so le");
            Console.WriteLine("3. Hien thi so nguyen to");
            Console.WriteLine("4. Hien thi so doi xung");
            Console.Write("Nhap: ");
            LoaiSo nhapLoaiSo = (LoaiSo) Convert.ToInt32(Console.ReadLine());
            soHocController.HienThi(nhapLoaiSo);
        }
    }
}
