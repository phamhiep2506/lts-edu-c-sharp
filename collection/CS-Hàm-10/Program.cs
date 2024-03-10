int CountSpace(string str) {
    char[] strArray = str.ToCharArray();
    int countSpace = 0;
    foreach(char c in strArray) {
        if(Char.IsWhiteSpace(c)) {
            countSpace += 1;
        }
    }
    return countSpace;
}

Console.WriteLine($"count space = {CountSpace("  tran   van  a ")}");
