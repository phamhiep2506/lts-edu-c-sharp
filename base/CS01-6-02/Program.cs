int a;
int s = 0;

Console.Write("Nhap a: ");
a = int.Parse(Console.ReadLine());

for(int i = 1; i < a; i++)
{
    if(a % i == 0 && i % 2 == 0)
    {
        s = s + i;
    }
}

Console.WriteLine(s);