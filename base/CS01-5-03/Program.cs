int a, b;

Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Nhap b: ");
b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("a lon hon b");
} else if (b > a)
{
    Console.WriteLine("b lon hon a");
}
