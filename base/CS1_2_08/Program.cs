int x, y, a, b, c;

Console.Write("x: ");
x = int.Parse(Console.ReadLine());

Console.Write("y: ");
y = int.Parse(Console.ReadLine());

Console.Write("a: ");
a = int.Parse(Console.ReadLine());

Console.Write("b: ");
b = int.Parse(Console.ReadLine());

Console.Write("c: ");
c = int.Parse(Console.ReadLine());

Console.WriteLine("Khoang cach tu diem A({0},{1}) den duong thang d: {2}x+{3}y + {4} = 0 la {5}", x, y, a, b, c, Math.Abs(a * x + b * y + c) / (a ^ 2 + b ^ 2));