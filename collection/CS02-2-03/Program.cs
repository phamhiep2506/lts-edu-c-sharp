List<int> arr = new List<int> {2, 3, 4, 5, 6, 7, 8};
List<int> newArr = new List<int> {};

for(int i = 0; i < arr.Count(); i++) {
    newArr.Add((int)Math.Pow(arr[i], 2));
}

int count = 0;
foreach(int a in newArr) {
    if(a > 20) {
        count += 1;
    }
    Console.WriteLine(a);
}

Console.WriteLine(count);
