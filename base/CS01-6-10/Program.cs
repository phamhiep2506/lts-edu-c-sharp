int a = 8;
int b = 14;

int UCLN(int a, int b) {
    while(a * b != 0) {
        if(a > b) {
            a %= b;
        } else {
            b %= a;
        }
    }
    return a + b;
}

int GCD(int a, int b) {
    if(a == 0 || b == 0) {
        return a + b;
    }
    while(a != b) {
        if(a > b) {
            a -= b;
        } else {
            b -= a;
        }
    }
    return a;
}

Console.WriteLine(UCLN(a, b));
Console.WriteLine(a * b / GCD(a, b));
