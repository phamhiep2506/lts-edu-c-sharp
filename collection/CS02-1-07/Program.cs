int[] arr = {1, 4, 1, 5, 6};
int n = 5;

Array.Sort(arr);

// print array sort
foreach(int a in arr) {
    Console.WriteLine(a);
}

// print index
Console.WriteLine(Array.IndexOf(arr, n));
