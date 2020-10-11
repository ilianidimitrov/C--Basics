using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;

            while (true)
            {
                string money = Console.ReadLine();
                if (money == "NoMoreMoney")
                {
                    Console.WriteLine("Total: {0}", x.ToString("0.00"));
                    break;
                }
                double length = 0;
                Double.TryParse(money, out length);
                x += length;
                double varable = length;
                if (length < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine("Total: {0}", (x - varable).ToString("0.00"));
                    break;
                }
                Console.WriteLine("Increase: {0}", length.ToString("0.00"));
            }   
        }
    }
}
