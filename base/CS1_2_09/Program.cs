double[] arr;
arr = new double[4];
double tong = 0.0f;
double kq;

for(int i = 0; i < 4; i++) {
    Console.Write("Nhap so " + (i + 1) + ": ");
    arr[i] = float.Parse(Console.ReadLine());
    tong += arr[i];
}

kq = tong / arr.Length;
Console.Write("Trung bình cộng: ");
Console.WriteLine(Math.Round(kq, 3));