bool ktSoTang(int number) {

    char[] num = number.ToString().ToCharArray();
    int temp = num[0];
    for(int i = 1; i < num.Length; i++) {
        if(temp > Convert.ToInt32(num[i])) {
            return false;
        }
        temp = num[i];
    }

    return true;
}

if(ktSoTang(1234)) {
    Console.WriteLine("La so tang");
} else {
    Console.WriteLine("Khong la so tang");
}

if(ktSoTang(1324)) {
    Console.WriteLine("La so tang");
} else {
    Console.WriteLine("Khong la so tang");
}
