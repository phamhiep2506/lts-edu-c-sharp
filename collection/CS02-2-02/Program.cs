List<int> ds = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8};

if(ds.Remove(9)) {
    Console.WriteLine("ok");
} else {
    Console.WriteLine("Phan tu khong ton tai trong danh sach");
}

if(ds.Remove(8)) {
    Console.WriteLine("ok");
} else {
    Console.WriteLine("Phan tu khong ton tai trong danh sach");
}

foreach(int d in ds) {
    Console.WriteLine(d);
}
