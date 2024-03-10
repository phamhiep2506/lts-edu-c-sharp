string str1, str2;

Console.Write("Nhap str1: ");
str1 = Console.ReadLine();

Console.Write("Nhap str2: ");
str2 = Console.ReadLine();

if(str2.Contains(str1))
{
    Console.WriteLine("{0} nam trong {1}", str1, str2);
} else
{
    Console.WriteLine("Chuoi{0} khong chua {1}", str1, str2);
}