namespace test_ef.Views;

public class Menu
{
    public void MenuCauHoi()
    {
        while (true)
        {
            Console.WriteLine(
                @"
            1. Lấy thông tin loại sản phẩm của từng sản phẩm (select TenSanPham, TenLoai)
            0. Thoát
            "
            );

            int cauHoi;
            bool success;
            do
            {
                Console.Write("Nhập câu hỏi: ");
                success = int.TryParse(Console.ReadLine(), out cauHoi);
                if (success == false)
                {
                    Console.WriteLine("[?] Nhập lại");
                }
            } while (!success);

            switch (cauHoi)
            {
                case 1:
                    new SanPham().HienThongTinSanPham();
                    break;

                case 0:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
