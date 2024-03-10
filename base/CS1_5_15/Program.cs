int a;

Console.Write("Nhap a:");
a = int.Parse(Console.ReadLine());

switch (a) { 
    case 2:
        Console.WriteLine("Thu hai");
        break;
    case 3:
        Console.WriteLine("Thu ba");
        break;
    case 4:
        Console.WriteLine("Thu tu");
        break;
    case 5:
        Console.WriteLine("Thu nam");
        break;
    case 6:
        Console.WriteLine("Thu sau");
        break;
    case 7:
        Console.WriteLine("Thu bay");
        break;
    case 8:
        Console.WriteLine("Chu nhat");
        break;
    default:
        Console.WriteLine("Khong phai la thu trong tuan");
        break;
}