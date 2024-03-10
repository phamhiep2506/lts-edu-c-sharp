int n = 123;

string a = n.ToString();
char[] b = a.ToCharArray();
int t = 1;
foreach(char x in b) {
    t = t * int.Parse(x.ToString());
}
Console.WriteLine(t);
