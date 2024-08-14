namespace BusTicketSalesSystem.models.ManageSys.Tools;

public static class StandardWord
{
    public static string ToStandard(this string value)
        => value.Replace(" ", "").ToLower();
}