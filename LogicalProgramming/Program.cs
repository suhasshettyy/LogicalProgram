using System;

namespace LogicalProgramming
{
    class Program
    {
        public void Viewprogram()
        {
            int choice;
            const int FIBONACCI_SERIES = 1, PERFECT_NUMBER = 2, PRIME_NUMBER = 3, REVERSE_NUMBER = 4;
            Console.WriteLine("Press 1 : Fibonacci Series Program");
            Console.WriteLine("Press 2 : Perfect Number Program");
            Console.WriteLine("Press 3 : Prime Number Program");
            Console.WriteLine("Press 4 : Reverse Number Program");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case FIBONACCI_SERIES:
                    FibonacciSeries fibonacci_series = new FibonacciSeries();
                    fibonacci_series.Fibonacci();
                    break;
                case PERFECT_NUMBER:
                    PerfectNumber perfect_number = new PerfectNumber();
                    perfect_number.Perfect();
                    break;
                case PRIME_NUMBER:
                    PrimeNumber prime_number = new PrimeNumber();
                    prime_number.Prime();
                    break;
                case REVERSE_NUMBER:
                    ReverseNumber reverse_number = new ReverseNumber();
                    reverse_number.Reverse();
                    break;
            }
            Console.WriteLine("\nPress Y to run other programs or else press N to exit");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
                Viewprogram();
            else
                Console.WriteLine("Thank You");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Viewprogram();
        }
    }
}