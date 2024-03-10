void CheckArray(int[] arr) {
    int countMT = 0;
    int countMG = 0;
    for(int i = 0; i < arr.Length - 1; i++) {
        if(arr[i] < arr[i + 1]) {
            countMT += 1;
        }
        if(arr[i] > arr[i + 1]) {
            countMG += 1;
        }
    }
    if(countMT == arr.Length - 1) {
        Console.WriteLine("Mang Tang");
    } else if(countMG == arr.Length - 1) {
        Console.WriteLine("Mang Giam");
    } else {
        Console.WriteLine("Mang Hon Don");
    }
}

int[] arr1 = {1,2,5,6,7,10};
int[] arr2 = {9,7,4,3,2,1};
int[] arr3 = {1,7,2,6,3,9};

CheckArray(arr1);
CheckArray(arr2);
CheckArray(arr3);
