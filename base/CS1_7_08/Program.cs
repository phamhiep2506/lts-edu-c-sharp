string str;

Console.Write("Nhap chuoi: ");
str = Console.ReadLine();

if (String.IsNullOrEmpty(str))
{
    Console.WriteLine("Chuoi Null");
} else
{
    Console.WriteLine("Nope, chuoi khong null");
}