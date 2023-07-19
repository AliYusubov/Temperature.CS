using System;
using System.Diagnostics.Metrics;

namespace ALi
{
    class NumberManipulator
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius:");
            int numr34;
            numr34 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The temperature in Fahrenheit is:{0}",( numr34 * 9)/5 + 32);


        }


    }
}