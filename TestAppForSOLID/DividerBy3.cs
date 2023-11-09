namespace TestAppForSOLID
{
    internal class DividerBy3 : IDivider  
    {
        public string CodeWord { get; }
        public int Divider { get; }

        public DividerBy3()
        {
            CodeWord = "dog";
            Divider = 3;
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
