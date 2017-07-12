using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class StringCalculator
    {
        public int Add(string numsToAdd)
        {
            int sum = 0;
            if (numsToAdd.Length !=0)
            {
                string delimiter = ",";
                if (numsToAdd.StartsWith("//"))
                {
                    int terminator = numsToAdd.IndexOf("\n");
                    delimiter = numsToAdd.Substring(2, terminator - 2);
                    numsToAdd = numsToAdd.Substring(terminator + 1);
                }
                numsToAdd = numsToAdd.Replace("\n", delimiter);
                string[] numberStrings = numsToAdd.Split(Char.Parse(delimiter));
                foreach(string number in numberStrings)
                {
                    sum += Int32.Parse(number);
                }
            }

            return sum;
        }
    }
}
