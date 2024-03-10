string str1, str2;

Console.Write("Nhap str1: ");
str1 = Console.ReadLine();

Console.Write("Nhap str2: ");
str2 = Console.ReadLine();

if (String.Compare(str1, str2, true) == 0) {
    Console.WriteLine("hai chuoi giong nhau, khong phan biet chu hoa chu thuong");
} else
{
    Console.WriteLine("hai chuoi khac nhau, khong phan biet chu hoa chu thuong");
}

if (String.Compare(str1, str2, false) == 0) {
    Console.WriteLine("hai chuoi giong nhau, co phan biet chu hoa chu thuong");
} else
{
    Console.WriteLine("hai chuoi khac nhau, co phan biet chu hoa chu thuong");
}