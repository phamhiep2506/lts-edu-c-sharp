void GetCharCenter(string str) {
    char[] s = str.ToCharArray();

    if(s.Length % 2 == 0) {
        Console.WriteLine($"{s[s.Length / 2 - 1]}{s[s.Length / 2]}");
    }
    if(s.Length % 2 != 0) {
        Console.WriteLine($"{s[s.Length / 2]}");
    }

}

GetCharCenter("kkcckk");
GetCharCenter("kkceckk");
