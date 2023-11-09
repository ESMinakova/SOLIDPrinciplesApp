using System.Text;
using NUnit.Framework;

namespace TestAppForSOLID.Tests
{
    [TestFixture]
    public class DividersTests
    {
        private CommonDivider commonDivider;

        [SetUp]
        public void Setup()
        {
            commonDivider = new CommonDivider();
        }


        [TestCase("1, -1, 2, -2", "1, -1, 2, -2")]
        [TestCase("3, -3", "dog, dog")]
        [TestCase("4, -4", "muzz, muzz")]
        [TestCase("5, -5", "cat, cat")]
        [TestCase("7, -7", "guzz, guzz")]
        [TestCase("15, -15", "good-boy, good-boy")]
        [TestCase("20, -20", "muzz-cat, muzz-cat")]
        [TestCase("12, -12, 60, -60", "dog-muzz, dog-muzz, good-boy-muzz, good-boy-muzz")]
        [TestCase("0, 420, -420", "good-boy-muzz-guzz, good-boy-muzz-guzz, good-boy-muzz-guzz")]
        [TestCase("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420",
            "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz")]
        public void ChangeValue (string input, string expected)
        {

            var numbers = new Numbers(input).numbers;
            var sb = new StringBuilder();

            numbers.ForEach(x => commonDivider.ReplaceValue(x));
            numbers.ForEach(x => sb.Append($"{x.OutgoingValue}, "));
            var result = sb.ToString().Trim().Trim(',');

            Assert.AreEqual(expected, result);
        }
    }
}
