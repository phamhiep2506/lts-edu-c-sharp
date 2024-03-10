int a, b, temp;

Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());

Console.Write("Nhap b: ");
b = int.Parse(Console.ReadLine());

temp = a;
a = b;
b = temp;

Console.WriteLine("a = {0}, b = {1}", a, b);