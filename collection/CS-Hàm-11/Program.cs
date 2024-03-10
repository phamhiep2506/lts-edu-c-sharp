int n = 4;
int[,] arr = new int[n, n];

void NhapMang() {
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < n; j++) {
            Console.Write($"Nhap [{i},{j}]: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void HienMang() {
    for(int i = 0; i < n; i++) {
        Console.Write("\n");
        for(int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]}\t");
        }
    }
    Console.Write("\n");
}

NhapMang();
HienMang();
