namespace test_ef.Views;

public class Menu
{
    public void MenuCauHoi()
    {
        while (true)
        {
            Console.WriteLine(
                @"
            Menu
            ---
            1. Lấy thông tin loại sản phẩm của từng sản phẩm (select TenSanPham, TenLoai)
            2. In ra danh sách các sản phẩm bán được trong năm 2019
            3. In ra danh sách sản phẩm thuộc loại 'Đồ ăn' sản xuất và được bán ra trong ngày 25/5/2020
            4. Tìm các số hiệu đơn đã mua sản phẩm thuộc loại sản phẩm 'Đồ ăn' hoặc 'Đồ uống', mỗi sản phẩm mua với số lượng từ 10 đến 20.
            5. In ra tổng tiền của các hóa đơn trong ngày 25/05/2020
            6. Tính tổng số sản phẩm của từng hóa đơn
            0. Thoát
            "
            );

            int cauHoi;
            bool success;
            do
            {
                Console.Write("Nhập câu hỏi: ");
                success = int.TryParse(Console.ReadLine(), out cauHoi);
                Console.WriteLine("---");
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
                case 2:
                    new SanPham().HienThongTinSanPhamKhongBanDuocNam2019();
                    break;
                case 3:
                    new SanPham().HienSanPhamTDoAnTrongNgay25052020();
                    break;
                case 4:
                    new SanPham().HienSanPhamTDoAnDoUong();
                    break;
                case 5:
                    new SanPham().HienTongTienTrongNgay25052020();
                    break;
                case 0:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
