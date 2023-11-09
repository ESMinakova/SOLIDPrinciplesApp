namespace TestAppForSOLID
{
    internal class Replacer
    {
        public static void GetReplacement(Number number, string newValue)
        {
            if (char.IsDigit(number.OutgoingValue[0]) || number.OutgoingValue[0] == '-')
                number.OutgoingValue = newValue;
            else
                number.OutgoingValue += $"-{newValue}";
        }
    }
}
