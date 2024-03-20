interface IDanhBa
{
    void SuaTenLienHe(string tenLienHe);
}

class DanhBa: IDanhBa
{
    public int ID { get; set; }
    public string TenLienHe {  get; set; }
    public int SoDienThoai { get; set; }
    public bool TrangThaiChan {  get; set; }

    public void SuaTenLienHe(string tenLienHe)
    {
        TenLienHe = tenLienHe;
    }
}