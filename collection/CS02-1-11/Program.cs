int[] arr = {6, 2, 5, 1, 4, 3};
int temp = 0;

for(int i = 0; i < arr.Length; i++) {
    for(int j = 0; j < arr.Length - 1; j++) {
        if(arr[j] > arr[j + 1]) {
            temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}

foreach(int i in arr) {
    Console.WriteLine(i);
}
