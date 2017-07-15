using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
         This command-line program accepts a series of decimal integer values as command line arguments,
         and displays each decimal value as itself and its binary equivalent.
         */
        static void Main(string[] args)
        {
            //create user-prompt for decimal values input
            //and parse values-input to string of double values.
            Console.WriteLine("Please enter in a series of decimal values:  ");
            string[] nums = Console.ReadLine().Split(' ');

            //create loop to convert values to binary equivalent, and print each in a separate line
            for (int i=0; i<nums.Length; i++)
            {
                int baseTen = int.Parse(nums[i]);
                string binaryEquiv = "";
                while (baseTen > 0)
                {
                    binaryEquiv = (baseTen % 2) + binaryEquiv;
                    baseTen = baseTen / 2;
                }
                Console.WriteLine($"{nums[i]} in binary is {binaryEquiv}");
            }
        }
    }
}
