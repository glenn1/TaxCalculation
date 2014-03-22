using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 79.95;
            double dRate = 0.06;
            int rate = 6;
            calculateTax(price, rate);
            calculateTax(price, dRate);
            Console.ReadLine();
        }
        public static void calculateTax(double price, double rate)
        {
            double tax = price * rate;
            Console.WriteLine("The tax is {0} with price of {1} and rate at {2}.",
                tax.ToString("C"), price.ToString("C"), rate.ToString("C"));
        }
        public static void calculateTax(double price, int rate)
        {
            double newRate = rate * .01;
            double tax = newRate * price;
            Console.WriteLine("The tax is {0} with price of {1} and rate at {2}.",
                tax.ToString("C"), price.ToString("C"), newRate.ToString("C"));

        }
    }
}
