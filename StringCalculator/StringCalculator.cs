using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        private const char comma_delimeter = ',';
        private const char line_delimeter = '\n';
        public int Add(string numbers)
        {
            //Test empty
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            //Check if string has only 1 number
            if (numbers.IndexOf(comma_delimeter) == -1 && !numbers.Contains(line_delimeter))
            {
                return HandleSingleNumber(numbers);
            }

            return HandleMultipleNumbers(numbers);


        }

        private int HandleSingleNumber(string number)
        {
            return Int32.Parse(number);
        }

        private int HandleMultipleNumbers(string numbers)
        {
            var split_numbers = numbers.Split(comma_delimeter, line_delimeter);
            int sum = 0;

            foreach (var number in split_numbers)
            {
                sum += Int32.Parse(number);
            }

            return sum;
        }
    }
}
