int a, b, c;

Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Nhap b: ");
b = int.Parse(Console.ReadLine());

Console.Write("Nhap c: ");
c = int.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("a la so lon nhat trong 3 so");
}
else if (b > c && b > c) { 
    Console.WriteLine("b la so lon nhat trong 3 so");
}
else if (c > a && c > b) { 
    Console.WriteLine("c la so lon nhat trong 3 so");
}
