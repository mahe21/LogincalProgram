using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumbers
    {
        public void ReverseNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            int remainder = 0;  

            while(number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reversed Number is: " + reverse);
            Console.ReadLine();
        }
    }
}
