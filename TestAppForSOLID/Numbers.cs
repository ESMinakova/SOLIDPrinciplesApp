namespace TestAppForSOLID
{
    public class Numbers
    {
        public List<Number> numbers { get; set; }

        public Numbers(string input)
        {
            numbers = GetNumbersFromString(input);
        }

        public List<Number> GetNumbersFromString(string input)
        {
            return input
                .Split(' ')
                .Select(x => x.Trim(','))
                .ToList()
                .Select(x => Convert.ToInt32(x))
                .Select(x => new Number(x))
                .ToList();
        }

    }
}
