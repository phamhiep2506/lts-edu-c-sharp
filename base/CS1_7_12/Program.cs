string str;

Console.Write("Nhap chuoi: ");
str = Console.ReadLine();

char[] charArray = str.ToCharArray();
Array.Reverse(charArray);

Console.WriteLine(new string(charArray));