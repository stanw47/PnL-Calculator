using System;

namespace Profit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the P&L Calculator! To get started, type in the purchase/entry/average price of the asset or item.");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What did you sell it for? Type in selling/exit/average price.");
            double sale1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many units? If you took a short position, enter a negative number.");
            double units1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What were your total expenses related to the transaction");
            double exp1 = Convert.ToDouble(Console.ReadLine());
            double pnl1 = ((units1 * (sale1 - price1)) - exp1);
            if (pnl1 > 0)
            {
                Console.WriteLine("Your profit is " + pnl1);
            }
            else if (pnl1 < 0)
            {
                Console.WriteLine("Your Loss is " + pnl1);
            }
        }
    }
}
