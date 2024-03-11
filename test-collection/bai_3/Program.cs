int n;

Console.Write("Nhap n: ");
n = Convert.ToInt32(Console.ReadLine());

// Convert binary to array 0 & 1
string binary = Convert.ToString(n, 2);

// add char binary to binArray[]
int[] binArray = new int[binary.Length];
for(int i = 0; i < binary.Length; i++)
{
    binArray[i] = int.Parse(binary[i].ToString());
}

// add binary to bin[]
int[] bin = new int[1] { 0 };
bin[0] = Convert.ToInt32(binary);


Console.WriteLine("Mang 1:");
foreach(int i in binArray)
{
    Console.WriteLine(i);
}

Console.WriteLine("Mang 2:");
foreach(int i in bin)
{
    Console.WriteLine(i);
}
