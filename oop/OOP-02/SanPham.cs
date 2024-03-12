public class SanPham
{
    public int MaSanPham {get; set;}
    public string TenSanPham {get; set;}
    public string LoaiSanPham {get; set;}
    public bool LaSanPhamMoi {get; set;}

    public SanPham(int MaSanPham, string TenSanPham, string LoaiSanPham, bool LaSanPhamMoi)
    {
        this.MaSanPham = MaSanPham;
        this.TenSanPham = TenSanPham;
        this.LoaiSanPham = LoaiSanPham;
        this.LaSanPhamMoi = LaSanPhamMoi;
    }

    public void InThongTin()
    {
        Console.WriteLine($"San pham {TenSanPham} co ma la {MaSanPham} thuoc loai {LoaiSanPham}, {LaSanPhamMoi} la san pham moi");
    }
}
