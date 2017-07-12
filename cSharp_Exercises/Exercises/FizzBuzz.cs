using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class FizzBuzz
    {
        public string fizzBuzz(int n)
        {
            if ((n < 1 || n > 100)) return "";
            bool isDivisibleBy5 = n % 5 == 0;
            bool isDivisibleBy3 = n % 3 == 0;
            if(isDivisibleBy3 && isDivisibleBy5)
            {
                return "FizzBuzz";
            }
            if (isDivisibleBy5)
            {
                return "Buzz";
            }
            if (isDivisibleBy3)
            {
                return "Fizz";
            }
            String stringNums = n.ToString();
            if (stringNums.Contains("5"))
            {
                return "Buzz";
            }
            if (stringNums.Contains("3"))
            {
                return "Fizz";
            }
            return stringNums;
        }
    }
}
