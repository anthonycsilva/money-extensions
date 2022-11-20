namespace MoneyExtension;
public static class MoneyExtension
{
    public static int ToCents(this decimal amount)
    {
        if (amount <= 0)
        {
            return 0;
        }
        var text = amount
        .ToString(format: "N2")
        .Replace(oldValue: ",", newValue: "")
        .Replace(oldValue: ".", newValue: "");

        int.TryParse(text, out var result);
        return result;
    }
}
