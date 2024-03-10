bool SoGiamGian(int a) {
    string s = a.ToString();
    char[] c = s.ToCharArray();
    int count = 0;
    for(int i = 0; i < c.Length - 1; i++) {
        if(int.Parse(c[i].ToString()) > int.Parse(c[i+1].ToString())) {
            count += 1;
        }
    }
    if(count == c.Length -1) {
        return true;
    } else {
        return false;
    }
}

if(SoGiamGian(876531)) {
    Console.WriteLine("True");
} else {
    Console.WriteLine("False");
}

if(SoGiamGian(1235667)) {
    Console.WriteLine("True");
} else {
    Console.WriteLine("False");
}
