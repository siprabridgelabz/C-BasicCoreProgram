using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class OddEven
    {
  
            public static void FindOddEven()
            {
              
                int n;

                
                Console.Write("Enter the number = ");
                n = Convert.ToInt32(Console.ReadLine());

             
                if (n % 2 == 0)
                    Console.WriteLine(n + " is even");
                else
                    Console.WriteLine(n + " is odd");

               
                Console.ReadKey();
            }
        }
    }








