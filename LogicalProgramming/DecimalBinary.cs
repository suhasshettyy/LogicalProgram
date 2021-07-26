using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class DecimalBinary
    {
        public void Binary()
        { 
        int i;
        Console.WriteLine("enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] binary = new int[10];
            for (i = 0; number > 0; i++)
            {
                binary[i] = number % 2;
                number /= 2;
            }
            Console.Write("Binary form ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    }
}