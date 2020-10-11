using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = Double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;

            Console.WriteLine(Math.Round(BGN, 2));
        }
    }
}
