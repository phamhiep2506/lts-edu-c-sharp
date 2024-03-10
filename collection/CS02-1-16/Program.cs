void CheckArray(int[] arr) {
    int count = 0;

    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] != arr[arr.Length - i - 1]) {
            count += 1;
        }
    }
    if(count == 0) {
        Console.WriteLine("Mang doi xung");
    } else {
        Console.WriteLine("Mang khong doi xung");
    }
}

int[] a = {1, 2, 3, 2, 1};
int[] b = {1, 4, 4, 1};
int[] c = {1, 2, 3, 3, 1};

CheckArray(a);
CheckArray(b);
CheckArray(c);
