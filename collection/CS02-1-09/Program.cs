int[] arr = {1,2,3,4,5,6};
List<int> newArrOdd = new List<int>();
int coutOdd = 0;
double percent = 0.0f;

for(int i = 0; i < arr.Length; i++) {
    if(arr[i] % 2 != 0) {
        newArrOdd.Add(arr[i]);
        coutOdd += 1;
    }
}

percent = ((double)coutOdd / (double)arr.Length) * 100;

Console.Write("Ti le = {0}/{1} = {2} va cac phan tu do la ", coutOdd, arr.Length, percent);

// print array
for(int i = 0; i < newArrOdd.Count; i++) {
    Console.Write(newArrOdd[i]);
}
