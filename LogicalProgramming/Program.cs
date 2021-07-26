using System;

namespace LogicalProgramming
{
    class Program
    {
        public void Viewprogram()
        {
            int choice;
            const int FIBONACCI_SERIES = 1, PERFECT_NUMBER = 2, PRIME_NUMBER = 3, REVERSE_NUMBER = 4, TEMPERATURE_CONVERSION = 5, DECIMAL_BINARY = 6, MONTHLY_PAYMENT = 7, DAY_WEEK = 8;
            Console.WriteLine("Press 1 : Fibonacci Series Program");
            Console.WriteLine("Press 2 : Perfect Number Program");
            Console.WriteLine("Press 3 : Prime Number Program");
            Console.WriteLine("Press 4 : Reverse Number Program");
            Console.WriteLine("Press 5 : Temperature Conversion Program");
            Console.WriteLine("Press 6 : Decimal to Binary Program");
            Console.WriteLine("Press 7 : Monthly Payment Program");
            Console.WriteLine("Press 8 : Day of Week Program");
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
                case TEMPERATURE_CONVERSION:
                    TemperatureConversion temperature_conversion = new TemperatureConversion();
                    temperature_conversion.Conversion();
                    break;
                case DECIMAL_BINARY:
                    DecimalBinary decimal_binary = new DecimalBinary();
                    decimal_binary.Binary();
                    break;
                case MONTHLY_PAYMENT:
                    MonthlyPayment monthly_payment = new MonthlyPayment();
                    monthly_payment.Payment();
                    break;
                case DAY_WEEK:
                    DayWeek day_week = new DayWeek();
                    day_week.Week();
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