double toan, van, anh, tbc;

Console.Write("Toan: ");
toan = double.Parse(Console.ReadLine());

Console.Write("Van: ");
van = double.Parse(Console.ReadLine());

Console.Write("Anh: ");
anh = double.Parse(Console.ReadLine());

tbc = (toan + van + anh) / 3;

if (tbc <= 4) {
    Console.WriteLine("Hoc luc cua hoc sinh la yeu");
} else if (tbc > 4 && tbc <= 6.5) {
    Console.WriteLine("Hoc luc cua hoc sinh la trung binh");
} else if (tbc > 6.5 && tbc <= 8) {
    Console.WriteLine("Hoc luc cua hoc sinh la kha");
} else if (tbc > 8 && tbc <= 9) {
    Console.WriteLine("Hoc luc cua hoc sinh la gioi");
} else if (tbc > 9) {
    Console.WriteLine("Hoc luc cua hoc sinh la xuat xac");
}