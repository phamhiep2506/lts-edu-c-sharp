int chieuCao;

Console.Write("Nhap chieu cao: ");
chieuCao = int.Parse(Console.ReadLine());

if (chieuCao < 145)
{
    Console.WriteLine("Rat lun");
}
else if (chieuCao < 150)
{
    Console.WriteLine("Lun");
}
else if(chieuCao >= 150 && chieuCao < 170)
{
    Console.WriteLine("Binh thuong");
} 
else if (chieuCao >= 170 && chieuCao <= 180)
{
    Console.WriteLine("Cao");
}
else if (chieuCao > 180)
{
    Console.WriteLine("Rat cao");
}