namespace TestAppForSOLID
{
    internal class DividerBy5 : IDivider
    {
        public string CodeWord { get; }
        public int Divider { get; }

        public DividerBy5()
        {
            CodeWord = "cat";
            Divider = 5;
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
