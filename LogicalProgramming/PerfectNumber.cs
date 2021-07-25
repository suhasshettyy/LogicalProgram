using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public void Perfect()
        {
            int number, sum = 0;
            Console.Write("enter the Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\nEntered number is a perfect number ");
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
            }
        }
    }
}
