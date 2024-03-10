string acc, pass;

string account = "nguyendongkhanh@hvitclan.vn";
string password = "123456";

Console.Write("Account: ");
acc = Console.ReadLine();

Console.Write("Password: ");
pass = Console.ReadLine();

if (acc == account && pass == password)
{
    Console.WriteLine("Success");
}
else {
    Console.WriteLine("Fail");
}