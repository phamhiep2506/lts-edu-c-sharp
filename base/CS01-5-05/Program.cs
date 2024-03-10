int a, b, c;

Console.Write("Nhap goc a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Nhap goc b: ");
b = int.Parse(Console.ReadLine());

Console.Write("Nhap goc c: ");
c = int.Parse(Console.ReadLine());

if (a + b + c == 180)
{
    if(a == 60 && b == 60 && c == 60)
    {
        Console.WriteLine("Tam giac deu");
    } else if(a == b || b == c || c == a)
    {
        Console.WriteLine("Tam giac can");
    } else if (a + b == 90 || b + c == 90 || c + a == 90)
    {
        Console.WriteLine("Tam giac vuong");
    }

} else
{
    Console.WriteLine("Khong phai la 1 tam giac");
}