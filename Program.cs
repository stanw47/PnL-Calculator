using System;

namespace Profit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the P&L Calculator! To get started, type in the purchase/entry price of the asset or item");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What did you sell it for?");
            double sale1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many units did you buy? If you took a short on a stock, type in a negative number.");
            double units1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
