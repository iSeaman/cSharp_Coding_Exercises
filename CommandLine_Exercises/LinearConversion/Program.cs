using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConversion
{
    class Program
    {
        /*
         This command-line program prompts user to enter a length, and whether its in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old & new measurements.
         The foot to meter conversion formula is:
            m = f * 0.3048
         The meter to foot conversion formula is:
            f = m * 3.2808399
         */
        static void Main(string[] args)
        {
            //create user-prompt for length measurement
            Console.WriteLine("Please enter the length:  ");
            //and parse length-input to double
            double userLength = double.Parse(Console.ReadLine());

            //create user-input for measurement type
            Console.WriteLine("Enter 'm' for meter, or 'f' for feet:  ");
            //and parse type-input to char
            char lengthType = char.Parse(Console.ReadLine());

            //create if-method for meters-2-feet conversion
            if (lengthType == 'm')
            {
                double f = userLength * 3.2808399;
                //print display of old measurements and new
                Console.WriteLine($"{userLength}m is {f}f.");
            }
            //create if-method for feet-2-meters conversion
            else if (lengthType == 'f')
            {
                double m = userLength * 0.3048;
                //print display of old measurements and new
                Console.WriteLine($"{userLength}f is {m}m.");
            }
            //Write else-statement for invalid choices
            else
            {
                Console.WriteLine(lengthType + " is an invalid choice.");
            }
        }
    }
}
