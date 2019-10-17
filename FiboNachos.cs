using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachos
{
    class Program
    {
        static void Main(string[] args)
        {

            //FiboNachos - A spicy recursion program :)

            long stopLength = 99999999999;

            for(long i = 0; i < stopLength; i++)
            {
                Console.Write(FiboNachoIt(i) + " ");
            }

        }

        static long FiboNachoIt(long n) // Some people like pancakes but everyone loves Nachos!
        {
            
            if (n == 0)
               return 0;
            if (n == 1)
                return 1;

            return FiboNachoIt(n - 1) + FiboNachoIt(n - 2);

        }

    }
}
