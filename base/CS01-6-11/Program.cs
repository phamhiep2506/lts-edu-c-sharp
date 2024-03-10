int a;

do { 
    Console.Write("Nhap a: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("So nguyen vua nhap la {0}", a);
} while (a < 0);
