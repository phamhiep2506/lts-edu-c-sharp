Console.Write("{");
for(int i = 1; i <= 50; i++)
{
    if(i == 50)
    {
        Console.Write("{0}", i);
    } else
    {
        Console.Write("{0},", i);
    }
}
Console.Write("}");