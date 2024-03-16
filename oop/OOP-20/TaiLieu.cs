abstract class TaiLieu
{
    public int MaTaiLieu { get; set; }
    public string TenNhaSanXuat { get; set; }
    public int SoBanPhatHanh { get; set; }
    public string TenTaiLieu { get; set; }

    public abstract void InThongTinTaiLieu();
    public abstract void NhapThongTinTaiLieu();

    public static List<TaiLieu> TimKiemTaiLieu(List<TaiLieu> taiLieus, string tenTaiLieu)
    {
        List<TaiLieu> newTaiLieu = new List<TaiLieu>();
        for(int i = 0; i < taiLieus.Count; i++)
        {
            if(taiLieus[i].TenTaiLieu.Contains(tenTaiLieu))
            {
                newTaiLieu.Add(taiLieus[i]);
            }
        }
        return newTaiLieu;
    }
}
