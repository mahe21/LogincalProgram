using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibnacciSeries
    {
        public void FibonacciSeries(int count)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            Console.WriteLine("Fibonacci series: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(firstNumber);
                int next = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = next;
            }
        }
    }
}
