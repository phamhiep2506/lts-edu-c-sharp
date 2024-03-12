class MonAn
{
    public string TenMonAn {get; set;}
    public int GiaBan {get; set;}
    public string GioiThieu {get; set;}
    public string NguyenLieuChinh {get; set;}

    public MonAn(string TenMonAn, int GiaBan, string GioiThieu, string NguyenLieuChinh)
    {
        this.TenMonAn = TenMonAn;
        this.GiaBan = GiaBan;
        this.GioiThieu = GioiThieu;
        this.NguyenLieuChinh = NguyenLieuChinh;
    }

    public void InThongTin()
    {
        Console.WriteLine($"Mon {TenMonAn}, {GioiThieu}, duoc lam tu cac nguyen lieu chinh {NguyenLieuChinh}");
    }
}
