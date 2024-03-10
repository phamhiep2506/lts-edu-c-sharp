string str;

Console.Write("Nhap ho ten: ");
str = Console.ReadLine();

str = str.Trim();
str = str.ToLower();
str = str.Replace(" ", "");

Console.WriteLine(str + "@hvitclan.com");