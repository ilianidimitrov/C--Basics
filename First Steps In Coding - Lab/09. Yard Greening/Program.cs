using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());

            double value_of_m2 = m2 * 7.61;
            double discount = (value_of_m2 * 18) / 100;
            double total = value_of_m2 - discount;

            Console.WriteLine(Math.Round(total, 2) + "The final price is: {0} lv.", total);
            Console.WriteLine(Math.Round(discount, 2) + "The discount is: {0} lv.", discount);
        }
    }
}
