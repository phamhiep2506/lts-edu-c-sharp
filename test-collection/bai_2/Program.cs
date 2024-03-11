int n;

bool CheckSoNguyenTo(int n)
{
    // n < 2 khong phai la so nguyen to
    if(n < 2)
    {
        return false;
    }

    for(int i = 2; i <= Math.Sqrt(n); i++)
    {
        if(n % i == 0)
        {
            return false;
        }

    }
    return true;
}

// Nhap n
Console.Write("Nhap n: ");
n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

// Nhap mang
for (int i = 0; i < n; i++)
{
    Console.Write($"Nhap [{i}]: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

// check so nguyen to va luu vao danh sach (List<int>)
List<int> newArr = new List<int> { };
for(int i = 0; i < arr.Length; i++)
{
    if (CheckSoNguyenTo(arr[i]))
    {
        newArr.Add(arr[i]); 
    }
}


// in danh sach so nguyen to
foreach(int i in newArr)
{
    Console.WriteLine(i);
}
