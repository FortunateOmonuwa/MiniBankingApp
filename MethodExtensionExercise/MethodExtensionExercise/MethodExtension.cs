using System.Globalization;

public static class MethodExtension
{
    public static string ExtensionMethod(this Decimal number)
    {
         number = 180.2m;
        return number.ToString("C2",CultureInfo.CurrentCulture);
        

    }
}