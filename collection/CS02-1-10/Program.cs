int[] arr = {1,20,2,3,4,5,6,7,8,9,10};

for(int i = 0; i < arr.Length; i++) {
    if(arr[i] % 10 == 0) {
        Console.WriteLine($"So dau tien trong mang la boi cua 10 la {arr[i]} o vi tri thu {i + 1}");
        break;
    }
}
