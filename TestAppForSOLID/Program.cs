// See https://aka.ms/new-console-template for more information


using TestAppForSOLID;


class Program
{
    public static void Main(string[] args)
    {
        var numbers = new Numbers(Console.ReadLine()).numbers;

        var commonDivider = new CommonDivider();
        numbers.ForEach(x => commonDivider.ReplaceValue(x));
        numbers.Take(numbers.Count - 1).ToList().ForEach(x => Console.Write($"{x.OutgoingValue}, "));
        Console.Write(numbers.Last().OutgoingValue);
    }
}
