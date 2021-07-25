using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class ReverseNumber
    {
        public void Reverse()
        {
            int n, reverse = 0, remainder;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}