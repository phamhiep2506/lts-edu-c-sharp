string hoTen;
int c = 0;
char[] hoTenKiTu;

Console.Write("Nhap ho ten: ");
hoTen = Console.ReadLine();

hoTenKiTu = hoTen.ToCharArray();

for(int i = 0; i < hoTenKiTu.Length; i++)
{
    if(Char.IsLetter(hoTenKiTu[i]))
    {
        c += 1;
    }
}

Console.WriteLine("Chuoi {0} co {1} chu cai", hoTen, c);
