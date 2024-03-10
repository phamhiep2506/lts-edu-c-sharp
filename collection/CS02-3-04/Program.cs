void checkNumber(string number) {
    int num;
    if(int.TryParse(number, out num)) {
        Console.WriteLine($"So vua nhap la: {num}");
    } else {
        Console.WriteLine("Sai quy cach, nhap lai!");
    }
}

checkNumber("5");
checkNumber("ttt");
