int[] arr = {1,2,3,4,5,6,7};
int tich = 1;

for(int i = 0; i < arr.Length; i++) {
    tich *= arr[i];
}

Console.WriteLine(tich);
