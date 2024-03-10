void InputArray(int n) {
    int[] arr = new int[n];
    Console.WriteLine("Nhap array: ");
    for(int i = 0; i < n; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Array vua nhap: ");
    foreach(int a in arr) {
        Console.WriteLine(a);
    }
}

InputArray(5);
