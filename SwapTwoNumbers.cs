using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwapTwoNumbers
    {
        public static void DisplaySwapNumber()
        {

            int a = 65, b = 20;
            Console.WriteLine("Before Swap a= " + a + "b=" + b);

            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swap a= " + a + "b=" + b);
        }
    }
}
