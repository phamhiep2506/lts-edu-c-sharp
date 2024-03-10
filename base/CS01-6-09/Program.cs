int a;

Console.WriteLine("Nhap a: ");
a = int.Parse(Console.ReadLine());

if(a < 2)
{
    Console.WriteLine("{0} khong phai la so nguyen to", a);
}

for(int i = 2; i < (a -1 ); i++)
{
    if(a % i == 0)
    {
        Console.WriteLine("{0} khong phai la so nguyen to", a);
    }
}

Console.WriteLine("{0} la so nguyen to", a);
