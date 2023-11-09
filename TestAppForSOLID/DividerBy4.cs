namespace TestAppForSOLID
{
    internal class DividerBy4 : IDivider
    {
        public string CodeWord { get; }
        public int Divider { get; }

        public DividerBy4()
        {
            CodeWord = "muzz";
            Divider = 4;
        }

        public void ChangeValue(Number number)
        {
            var isDivides = (number.IncomingValue % Divider == 0);
            if (isDivides)
            {
                Replacer.GetReplacement(number, CodeWord);
            }
            
        }
    }
}
