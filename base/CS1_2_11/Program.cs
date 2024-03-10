string hoTen;
string ngaySinh;

Console.Write("Ho ten: ");
hoTen = Console.ReadLine();

Console.Write("Ngay sinh: ");
ngaySinh = Console.ReadLine();

string[] dateSplit = ngaySinh.Split("/");

DateTime date = new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0]));

Console.WriteLine("Ho ten: {0}", hoTen);
Console.WriteLine("Ngay ve huu: {0}/{1}/{2}", date.Day, date.Month, date.Year + 60);