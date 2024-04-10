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
            7. Tìm khách hàng có số lần mua hàng nhiều nhất
            8. Tìm hóa đơn có mua 3 sản phẩm do Việt Nam sản xuất (3 sản phẩm khác nhau)
            9. Tháng mấy trong năm 2019 có doanh số bán hàng cao nhất
            10. Cho biết trị giá hóa đơn cao nhất là bao nhiêu
            11. Cho biết trị giá hóa đơn thấp nhất là bao nhiêu
            12. Tìm sản phẩm có tổng số lượng bán ra thấp nhất trong năm 2019
            13. [Không có dữ liệu phù hợp] Loại sản phẩm nào bán chạy nhất từ đầu năm đến nay
            14. Tìm những loại sản phẩm được bán ra trong ngày 9/6/2020
            15. Tìm những khách hàng ở Hà Nội đã mua sản phẩm trong tháng 6 năm 2020
            16. [Không có dữ liệu phù hợp] Tìm những sản phẩm chưa bán được trong 6 tháng vừa qua
            17. Tìm những hóa đơn có 3 loại sản phẩm khác nhau
            18. Tìm những khách hàng đặt trên 100 sản phẩm trong 1 hóa đơn
            19. Tìm những sản phẩm chỉ được đặt 1 lần duy nhất
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
                case 6:
                    new SanPham().HienTongSoSanPhamTungHoaDon();
                    break;
                case 7:
                    new KhachHang().HienKhachHangMuaNhieuNhat();
                    break;
                case 8:
                    new DonHang().Hien3SanPhamDoVietNamSX();
                    break;
                case 9:
                    new DonHang().HienThang2019DanhSoCao();
                    break;
                case 10:
                    new DonHang().HienGiaTriHoaDonCaoNhat();
                    break;
                case 11:
                    new DonHang().HienGiaTriHoaDonThapNhat();
                    break;
                case 12:
                    new SanPham().HienSanPhamBanThapNhat2019();
                    break;
                case 13:
                    Console.WriteLine("[Không có dữ liệu phù hợp]");
                    break;
                case 14:
                    new SanPham().HienSanPhamBanRa09062020();
                    break;
                case 15:
                    new KhachHang().HienKhachHangMuaSanPhamHaNoi();
                    break;
                case 16:
                    Console.WriteLine("[Không có dữ liệu phù hợp]");
                    break;
                case 17:
                    new DonHang().HienHoaDon3LoaiSP();
                    break;
                case 18:
                    new KhachHang().HienKhachHangDatTren100SP();
                    break;
                case 19:
                    new SanPham().HienSanPhamChiDat1Lan();
                    break;
                case 0:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
