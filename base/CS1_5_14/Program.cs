string str;
int cs = 0;
int cc = 0; 
int kt = 0;

Console.Write("Nhap chuoi: ");
str = Console.ReadLine();

List<char> charArrays = str.ToList();

foreach(char charArray in charArrays)
{
    if(Char.IsDigit(charArray))
    {
        cs += 1;
    }
    else if(Char.IsLetter(charArray))
    {
        cc += 1;
    } else
    {
        kt += 1;
    }

}

Console.WriteLine("Chuoi {0} co {1} chu so, {2} chu cai va {3} ky tu", str, cs, cc, kt);