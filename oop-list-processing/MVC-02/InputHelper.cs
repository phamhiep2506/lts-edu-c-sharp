class InputHelper
{
    public enum ErrorType { 
        HSDaTonTai,
        MHDaTonTai,
        HSChuaTonTai,
        MHChuaTonTai,
        DanhSachTrong,
        ThanhCong
    }

    public static void InErrorType(ErrorType err)
    { 
        switch(err)
        {
            case ErrorType.HSDaTonTai:
                Console.WriteLine("Hoc Sinh Da Ton Tai!");
                break;
            case ErrorType.MHDaTonTai:
                Console.WriteLine("Mon Hoc Da Ton Tai!");
                break;
            case ErrorType.HSChuaTonTai:
                Console.WriteLine("Hoc Sinh Chua Ton Tai!");
                break;
            case ErrorType.MHChuaTonTai:
                Console.WriteLine("Mon Hoc Chua Ton Tai!");
                break;
            case ErrorType.DanhSachTrong:
                Console.WriteLine("Danh Sach Trong!");
                break;
            case ErrorType.ThanhCong:
                Console.WriteLine("Thanh Cong!");
                break;
        }
    }

    public static int NhapSo(string msg)
    {
        Console.Write($"{msg}");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static double NhapDouble(string msg)
    {
        Console.Write($"{msg}");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static string NhapChuoi(string msg)
    {
        Console.Write($"{msg}");
        return Console.ReadLine();
    }

    public static DateTime NhapDate(string msg)
    {
        Console.Write($"{msg}");
        return DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
    }
}