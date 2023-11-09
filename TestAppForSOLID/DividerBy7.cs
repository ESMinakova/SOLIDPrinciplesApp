namespace TestAppForSOLID
{
    internal class DividerBy7 : IDivider
    {
        public string CodeWord { get; }
        public int Divider { get; }

        public DividerBy7()
        {
            CodeWord = "guzz";
            Divider = 7;
        }

        public void ChangeValue(Number number)
        {
            var isDivides = (number.IncomingValue % Divider == 0);
            if (isDivides)
            {
                Replacer.GetReplacement(number,  CodeWord);
            }
            
        }
    }
}
