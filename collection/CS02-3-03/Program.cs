bool LaSoChinhPhuong(int n) {
    if(Math.Sqrt(n) * Math.Sqrt(n) == n) {
        return true;
    } else {
        return false;
    }
}

if(LaSoChinhPhuong(4)) {
    Console.WriteLine("La so chinh phuong");
} else {
    Console.WriteLine("Khong la so chinh phuong");
}

if(LaSoChinhPhuong(5)) {
    Console.WriteLine("La so chinh phuong");
} else {
    Console.WriteLine("Khong la so chinh phuong");
}
