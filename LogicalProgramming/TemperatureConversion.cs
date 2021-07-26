using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class TemperatureConversion
    {
        const int celtofar = 1;
        const int fahtocel = 2;
        public void Conversion()
        {
            Console.WriteLine("Enter\n" +
                "1.for celcius to farenheit\n" +
                "2.For farenheit to celcius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case celtofar:
                    Console.WriteLine("enter the temperature in celcius");
                    double celcius = Convert.ToDouble(Console.ReadLine());
                    double ctf = (celcius * 9 / 5) + 32; 
                    Console.WriteLine("temperature in " + celcius + " Celcius" + " is equal to " + ctf + " fahrenheit");
                    break;
                case fahtocel:
                    Console.WriteLine("enter the temperature in fahrenheit");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double ftc = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("temperature in " + fahrenheit + " Fahrenheit" + " is equal to " + ftc + " fahrenheit");
                    break;
            }
        }
    }
}
