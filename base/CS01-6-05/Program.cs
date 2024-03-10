int n;
int t = 1;

Console.Write("Nhap n: ");
n = int.Parse(Console.ReadLine());

for(int i = 1; i < n; i++)
{
    if(Math.Sqrt(i) * Math.Sqrt(i) == i)
    {
        t = t * i;
    }
}

Console.WriteLine(t);