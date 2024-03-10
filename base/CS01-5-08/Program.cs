int thang;

Console.Write("Nhap thang: ");
thang = int.Parse(Console.ReadLine());

if (thang < 0 && thang <= 3) {
    Console.WriteLine("Mua xuan");
}
else if (thang < 3 && thang <= 6)
{
    Console.WriteLine("Mua ha");
}
else if (thang < 6 && thang <= 9)
{
    Console.WriteLine("Mua thu");
}
else if (thang < 9 && thang <= 12)
{
    Console.WriteLine("Mua dong");
}