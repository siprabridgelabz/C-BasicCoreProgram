using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientAndReminder
    {
        public static void FindQuotientAndReminder()
        {
            int dividend = 67, divisor = 5;

            int remainder = dividend % divisor;
            int Quotient = dividend / divisor;
            Console.WriteLine("The Dividend {0} and divisor {1}", dividend, divisor);
            Console.WriteLine("The Quotient is " +Quotient+ "The Remainder is " +remainder);

        }
    }
}
