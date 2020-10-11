using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double Price_of_strawberries_in_BGN = double.Parse(Console.ReadLine());
            double Quantity_of_bananas_in_kilograms = double.Parse(Console.ReadLine());
            double Quantity_of_oranges_in_kilograms = double.Parse(Console.ReadLine());
            double Quantity_of_raspberries_in_kilograms = double.Parse(Console.ReadLine());
            double Quantity_of_strawberries_in_kilograms = double.Parse(Console.ReadLine());

            double the_price_of_raspberries = (Price_of_strawberries_in_BGN / 2);
            double the_price_of_oranges = the_price_of_raspberries - (0.4 * the_price_of_raspberries);
            double the_price_of_bananas = the_price_of_raspberries - (0.8 * the_price_of_raspberries);
            double raspberries = Quantity_of_raspberries_in_kilograms * the_price_of_raspberries;
            double oranges = Quantity_of_oranges_in_kilograms * the_price_of_oranges;
            double bananas = the_price_of_bananas * Quantity_of_bananas_in_kilograms;
            double strawberries = Quantity_of_strawberries_in_kilograms * Price_of_strawberries_in_BGN;

            double total = raspberries + oranges + bananas + strawberries;

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
