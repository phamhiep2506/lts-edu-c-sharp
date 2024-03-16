PhanSo phanSo1 = new PhanSo(6, 8);
PhanSo phanSo2 = new PhanSo(10, 20);

phanSo1.InThongSo();
phanSo2.InThongSo();

Console.WriteLine(PhanSo.Cong(phanSo1, phanSo2));
Console.WriteLine(PhanSo.Tru(phanSo1, phanSo2));
