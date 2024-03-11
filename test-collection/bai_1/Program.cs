
int[] NhapMang() {
    int n;
    Console.Write("Nhap n: ");
    n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    if (n > 2 && n < 50) {
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Nhap arr[{i}]: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    } else
    {
        Console.WriteLine("Nhap lai n");
    }

    return arr;
}

void HienMang(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

void SapXep(int[] arr)
{
    int temp;
    for(int i = 0; i < arr.Length -1; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > 0 && arr[j] > 0 && arr[i] > arr[j] ||
                arr[i] < 0 && arr[j] < 0 && arr[i] < arr[j] ||
                arr[i] < 0 && arr[j] > 0) {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

        }
    }
}

int[] arr = new int[] { };
arr = NhapMang();
SapXep(arr);
HienMang(arr);