using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppForSOLID
{
    internal class DividerBy15 : IDivider
    {
        public string CodeWord { get; }
        public int Divider { get; }

        public DividerBy15()
        {
            CodeWord = "good-boy";
            Divider = 15;
        }

        public void ChangeValue(Number number)
        {
            var isDivides = (number.IncomingValue % Divider == 0);
            if (isDivides) {
                
                number.OutgoingValue = EditValue(number);
            }
        }

        public string EditValue(Number number)
        {
           var result = number.OutgoingValue.Replace("dog", CodeWord)
               .Replace("-cat", "");
           return result;
        }
    }
}
