int thang, nam;

Console.Write("Nhap thang: ");
thang = int.Parse(Console.ReadLine());

Console.Write("Nhap nam: ");
nam = int.Parse(Console.ReadLine());

if(nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
{
    if(thang == 2)
    {
        Console.WriteLine("Thang {0} - Nam {1} co 29 ngay", thang, nam);
    } else
    {
        Console.WriteLine("Thang {0} - Nam {1} co 31 ngay", thang, nam);
    }
}
else
{
    Console.WriteLine("Thang {0} - Nam {1} co 31 ngay", thang, nam);
}