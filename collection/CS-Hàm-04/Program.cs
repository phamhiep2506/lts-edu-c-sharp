void CheckInput(string num) {
    int number;
    if(int.TryParse(num, out number)) {
        Console.WriteLine($"num = {number}");
    } else {
        Console.WriteLine("Input sai");
    }
}

CheckInput("5");
CheckInput("ffvhfbhvbf");
