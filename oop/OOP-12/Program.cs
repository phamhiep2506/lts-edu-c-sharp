HocVien hocVien1 = new HocVien();
HocVien hocVien2 = new HocVien();
HocVien hocVien3 = new HocVien();

List<HocVien> hocViens = new List<HocVien>();
hocViens.Add(hocVien1);
hocViens.Add(hocVien2);
hocViens.Add(hocVien3);

foreach (HocVien hocVien in HocVien.TimKiemHocVien("a", hocViens))
{
    Console.WriteLine(hocVien.HoTen);
};
