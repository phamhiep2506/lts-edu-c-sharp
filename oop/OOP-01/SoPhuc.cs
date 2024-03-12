public class SoPhuc {
    public double PhanThuc { get; set; }
    public double PhanAo { get; set; }

    public void InThongTin()
    {
        Console.WriteLine($"{PhanThuc}+{PhanAo}i");
    }
}
