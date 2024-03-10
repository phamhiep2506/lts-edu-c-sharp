int gio, phut, giay, quangDuong;

Console.Write("gio = ");
gio = int.Parse(Console.ReadLine());

Console.Write("phut = ");
phut = int.Parse(Console.ReadLine());

Console.Write("giay = ");
giay = int.Parse(Console.ReadLine());

Console.Write("quang duong = ");
quangDuong = int.Parse(Console.ReadLine());

int kmH = quangDuong / gio;
int mS = quangDuong * 1000 / gio * 60 * 60 + phut * 60 + giay;
int mH = quangDuong * 1000 / gio;

Console.WriteLine("Van toc km/h la: {0} km/h Van toc theo m/s la: {1} m/s Van toc theo m/h la: {2} m/h", kmH, mS, mH);
