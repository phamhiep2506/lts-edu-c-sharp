int a1, a2, b1, b2;

Console.Write("Nhap a1: ");
a1 = int.Parse(Console.ReadLine());
Console.Write("Nhap a2: ");
a2 = int.Parse(Console.ReadLine());

Console.Write("Nhap b1: ");
b1 = int.Parse(Console.ReadLine());
Console.Write("Nhap b2: ");
b2 = int.Parse(Console.ReadLine());

if (a1 * a2 == -1)
{
    Console.WriteLine("Hai duong thang vuong goc");
}
else if (a1 != a2)
{
    Console.WriteLine("Hai duong thang cat nhau");
}
else if (a1 == a2 && b1 != b2) { 
    Console.WriteLine("Hai duong thang song song");
} else if(a1 == a2 && b1 == b2)
{
    Console.WriteLine("Hai duong thang trung nhau");
}