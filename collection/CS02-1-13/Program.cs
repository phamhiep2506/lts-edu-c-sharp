int[] arr = {4,3,5,1,6,8,2};
int temp = 0;

for(int i = 0; i < arr.Length - 1; i++) {
    for(int j = i + 1; j < arr.Length; j++) {
            if(arr[i] % 2 != 0 && arr[j] % 2 == 0 ||
                    arr[i] > arr[j] && arr[i] % 2 == 0 && arr[j] % 2 == 0 ||
                    arr[i] < arr[j] && arr[i] % 2 != 0 && arr[j] % 2 != 0) {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
    }
}

for(int i = 0; i < arr.Length; i++) {
    Console.WriteLine(arr[i]);
}
