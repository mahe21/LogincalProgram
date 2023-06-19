using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void PrimeNum()
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            if(IsPrimeNumber(number))
            {
                Console.WriteLine(number + "is the prime number.");
            }
            else
            {
                Console.WriteLine(number + "is not a prime number");
            }


        }
        public bool IsPrimeNumber(int number)
        {
            if(number < 2)
            {
                return false;
            }
            for(int divisor = 2; divisor <= number/2; divisor++)
            {
                if(number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
