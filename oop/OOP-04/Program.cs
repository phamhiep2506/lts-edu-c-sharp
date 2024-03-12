class Program
{
    static void Main(string[] args)
    {
        SoThuc soThuc = new SoThuc(4.5);

        double maxBaSo = soThuc.TimMax(2.3, 1.1, 3.4);
        Console.WriteLine($"Max 3 so: {maxBaSo}");

        double canBacN = soThuc.TinhCanBacN(3);
        Console.WriteLine($"Can bac 3 {canBacN}");
    }
}
