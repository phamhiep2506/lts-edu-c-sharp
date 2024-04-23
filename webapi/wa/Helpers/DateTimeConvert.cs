using System.Globalization;

namespace wa.Helpers;

public class DateTimeConvert
{
    public static DateTime stringToDateTime(string? s)
    {
        DateTime dateTime;
        bool isDateTime = DateTime.TryParseExact(
            s,
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out dateTime
        );
        if (!isDateTime)
        {
            return default;
        }
        return dateTime;
    }

    public static string dateTimeToString(DateTime dateTime)
    {
        return dateTime.ToString("dd/MM/yyyy");
    }
}
