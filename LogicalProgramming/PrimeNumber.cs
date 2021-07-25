using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class PrimeNumber
    {
        public void Prime()
        {
            int number;
            Console.WriteLine("Accept number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");
                Console.ReadLine();
            }
        }
    }
}