char a;

Console.Write("Nhap 1 ki tu: ");
a = char.Parse(Console.ReadLine());

if (Char.IsLetterOrDigit(a))
{
    Console.WriteLine("{0} khong phai la mot ky tu dac biet", a);
}
else { 
    Console.WriteLine("{0} la mot ky tu dac biet", a);
}