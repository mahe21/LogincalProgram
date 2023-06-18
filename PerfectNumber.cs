using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static bool isPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum == number;
        }

        public void perfectNumber()
        {
            int limit = 1000;
            Console.WriteLine("Perfect Numer");
            for (int i = 0;i < limit; i++)
            {
                if (isPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
