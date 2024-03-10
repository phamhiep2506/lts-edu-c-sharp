int CountSpace(string str) {
    int count = 0;
    foreach(char c in str.ToCharArray()) {
        if(Char.IsWhiteSpace(c)) {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine($"Co {CountSpace("Tran Van A")} khoang trang");
