List<int> NhapMang(int n) {
    List<int> arr = new List<int> {};
    for(int i = 0; i < n; i++) {
        Console.Write($"Nhap [{i}]: ");
        arr.Add(Convert.ToInt32(Console.ReadLine()));
    }
    return arr;
}

void HienMang(List<int> arr) {
    Console.WriteLine("Cac phan tu cua mang la:");
    for(int i = 0; i < arr.Count(); i++) {
        Console.Write(arr[i]);
        Console.Write(" ");
    }
    Console.Write("\n");
}

List<int> ArrayLe(List<int> arr) {
    List<int> a = new List<int> {};
    Console.WriteLine("Cac phan tu le trong mang do la:");
    for(int i = 0; i < arr.Count(); i++) {
        if(arr[i] % 2 != 0) {
            a.Add(arr[i]);
        }
    }
    return a;
}

bool LaSoNguyenTo(int n)
{
    if (n < 2){
        return false;
    }
    for (int i = 2; i < (n - 1); i++){
        if (n % i == 0){
            return false;
        }
    }
    return true;
}

List<int> SoNguyenTo(List<int> arr) {
    List<int> a = new List<int> {};
    for(int i = 0; i < arr.Count(); i++) {
        if(LaSoNguyenTo(arr[i])) {
            a.Add(arr[i]);
        }
    }
    return a;
}

List<int> arr = new List<int> {};
arr = NhapMang(8);
HienMang(arr);

arr = ArrayLe(arr);
for(int i = 0; i < arr.Count; i++) {
    Console.Write(arr[i]);
    Console.Write(" ");
}
Console.Write("\n");

arr = SoNguyenTo(arr);
Console.WriteLine("Cac phan tu le la so nguyen to la:");
for(int i = 0; i < arr.Count; i++) {
    Console.Write(arr[i]);
    Console.Write(" ");
}
Console.Write("\n");
