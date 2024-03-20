class InputHelper
{
    public static int InputInt(string msg)
    {
        int number;
        bool success;

        do
        {
            Console.Write($"{msg}");
            string value = Console.ReadLine();
            success = int.TryParse(value, out number);
            if(!success)
            {
                Console.WriteLine("[?] Nhap Lai! Dau Vao Phai La So");
            }
        } while (!success);

        return number;
    }

    public static string InputString(string msg)
    {
        bool success;
        string value;

        do
        {
            Console.Write($"{msg}");
            value = Console.ReadLine();
            if(value.Length > 10)
            {
                Console.WriteLine("[?] Nhap Lai! Dau vao khong qua 10 ki tu");
                success = false;
            } else
            {
                success = true;
            }
            
        } while (!success);

        return value;
    }
}