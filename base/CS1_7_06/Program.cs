string str;
char i;

Console.Write("Nhap chuoi: ");
str = Console.ReadLine();

Console.Write("Nhap chon: ");
i = char.Parse(Console.ReadLine());

Console.WriteLine("Ky tu {0} lan dau tien xuat hien trong {1} o vi tri thu {2} & Ky tu {3} ln cuoi cung xuat hien trong chuoi {4} o vi tri thu {5}", i, str, str.IndexOf(i), i, str, str.LastIndexOf(i));