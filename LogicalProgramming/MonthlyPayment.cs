using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class MonthlyPayment
    {
    public void Payment()
        {
            Console.WriteLine("enter Principal Loan Amount");
            double Principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter Interest");
            double Interest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter no of Years to pay");
            double Years = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Years;
            double r = Interest / (12 * 100);
            double payment = Principal* r / 1 - Math.Pow((1 + r), (-n));
            Console.WriteLine("Monthly Payment is " + payment);
        }
    }
}