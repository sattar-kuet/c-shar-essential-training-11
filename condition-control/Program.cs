using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_control
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;

            /* if(a>b)
             {
                 Console.WriteLine("a is greater than b");
             }
             else
             {
                 Console.WriteLine("b is greater than a");

             }*/
            /* if (a > b)
             {
                 Console.WriteLine("a is greater than b");
             }
             if (a > 0)
             {
                 Console.WriteLine("a is positive");
             }
             a = 5
             b = 1


             */
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is less than b");
            }
            else
            {
                Console.WriteLine("a is equal to b");
            }
        }
    }
}
