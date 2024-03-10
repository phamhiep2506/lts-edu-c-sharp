char kiTu;

Console.Write("Nhap ki tu: ");
kiTu = char.Parse(Console.ReadLine());

if (char.IsUpper(kiTu))
{
    Console.WriteLine("{0} la nguyen am", kiTu);
}
else if (char.IsLower(kiTu))
{
    Console.WriteLine("{0} la phu am", kiTu);
}
else {
    Console.WriteLine("{0} khong la nguyen am va phu am", kiTu);
}
