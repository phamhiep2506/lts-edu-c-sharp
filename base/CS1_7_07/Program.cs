string str1, str2;

Console.Write("Nhap chuoi 1: ");
str1 = Console.ReadLine();

Console.Write("Nhap chuoi 2: ");
str2 = Console.ReadLine();

if(str1.Contains(str2))
{
    Console.WriteLine("Tim thay chuoi con trong chuoi ban dau da nhap");
}
else
{
    Console.WriteLine("Khong ton tai chuoi con nao nhu the");
}