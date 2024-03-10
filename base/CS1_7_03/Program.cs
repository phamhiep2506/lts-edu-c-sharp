string str1, str2;

Console.Write("Nhap str 1: ");
str1 = Console.ReadLine();

Console.Write("Nhap str 2: ");
str2 = Console.ReadLine();

if(String.Compare(str1, str2) == 0)
{
    Console.WriteLine("Hai chuoi giong nhau");
} else
{
    Console.WriteLine("Hai chuoi khac nhau");
}
