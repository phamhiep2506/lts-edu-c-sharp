string[] arr;
int n;
string temp;

Console.Write("Nhap n: ");
n = int.Parse(Console.ReadLine());

arr = new string[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine();
}

for (int i = 0; i < arr.Length; i++)
{
    for(int j = 0; j < arr.Length -1; j++)
    {
        if (arr[j].Length > arr[j+1].Length) {
            temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }

    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i] + " ");
}
