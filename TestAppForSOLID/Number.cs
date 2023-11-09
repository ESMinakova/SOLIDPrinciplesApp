namespace TestAppForSOLID
{
    public class Number
    {
        public int IncomingValue { get; }
        public string OutgoingValue { get; set; }


        public Number(int incomingValue)
        {
            IncomingValue = incomingValue;
            OutgoingValue = incomingValue.ToString();
        }

    }
}
