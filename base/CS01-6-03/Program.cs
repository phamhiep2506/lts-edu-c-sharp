int a;
int s = 0;

Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());

for (int i = 1; i < a; i++)
{
    if(i % 2 != 0 && a % i == 0)
    {
        s = i;
    }
}

Console.WriteLine(s);