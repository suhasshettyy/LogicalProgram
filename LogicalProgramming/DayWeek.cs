using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class DayWeek
    {
        const int sunday = 0;
        const int monday = 1;
        const int tuesday = 2;
        const int wednesday = 3;
        const int thursday = 4;
        const int friday = 5;
        const int saturday = 6;
        public void Week()
        {
            Console.WriteLine("enter Month by number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter day by number");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int y = Convert.ToInt32(Console.ReadLine());
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m / 12)) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine(d0);
            switch (d0)
            {
                case sunday:
                    Console.WriteLine("Its sunday");
                    break;
                case monday:
                    Console.WriteLine("Its monday");
                    break;
                case tuesday:
                    Console.WriteLine("Its tuesday");
                    break;
                case wednesday:
                    Console.WriteLine("Its wednesday");
                    break;
                case thursday:
                    Console.WriteLine("Its thursday");
                    break;
                case friday:
                    Console.WriteLine("Its friday");
                    break;
                case saturday:
                    Console.WriteLine("Its saturday");
                    break;
                default:
                    Console.WriteLine("wrong calculation");
                    break;

            }
        }
    }
}
