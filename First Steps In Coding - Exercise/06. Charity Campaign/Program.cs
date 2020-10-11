using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_days = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double total = (((cake * 45) + (waffles * 5.80) + (pancakes * 3.20)) * confectioner) * number_of_days - (((cake * 45) + (waffles * 5.80) + (pancakes * 3.20)) * confectioner) * number_of_days / 8;

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
