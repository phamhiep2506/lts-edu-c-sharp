int a;
Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {
    Console.WriteLine("{0} la so chan", a);
} else {
    Console.WriteLine("{0} la so le", a);
}