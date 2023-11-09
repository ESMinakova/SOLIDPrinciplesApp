namespace TestAppForSOLID
{
    public class CommonDivider
    {
        private readonly List<IDivider> dividingRules;

        public CommonDivider()
        {
            dividingRules = new List<IDivider>()
            {
                new DividerBy3(),
                new DividerBy4(),
                new DividerBy5(),
                new DividerBy7(),
                new DividerBy15()
            };
        }

        public void ReplaceValue(Number number)
        {
            dividingRules.ForEach(rule => rule.ChangeValue(number));
        }
    }
}
