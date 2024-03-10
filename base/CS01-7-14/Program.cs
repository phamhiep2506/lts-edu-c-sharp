int ngay, thang, nam;

DateTime date;

Console.Write("Nhap ngay: ");
ngay = int.Parse(Console.ReadLine());

Console.Write("Nhap thang: ");
thang = int.Parse(Console.ReadLine());

Console.Write("Nhap nam: ");
nam = int.Parse(Console.ReadLine());


date = new DateTime(nam, thang, ngay);

Console.WriteLine("Ngay thang nam vua nhap la {0}", date);
