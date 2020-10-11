using System;

namespace _07._Toy_Shop
{
    class Program
    { 
        static void Main(string[] args)
        {
            double Price_of_the_trip = double.Parse(Console.ReadLine());
            int Number_of_puzzles = int.Parse(Console.ReadLine());
            int Number_of_talking_dolls = int.Parse(Console.ReadLine());
            int Number_of_teddy_bears = int.Parse(Console.ReadLine());
            int Number_of_minions = int.Parse(Console.ReadLine());
            int Number_of_trucks = int.Parse(Console.ReadLine());

            double puzzle = 2.60, talking_doll = 3, teddy_bear = 4.10, minion = 8.20, truck = 2;

            int num = Number_of_minions + Number_of_puzzles + Number_of_talking_dolls + Number_of_teddy_bears + Number_of_trucks;

            double amount = (Number_of_minions * minion) + (Number_of_trucks * truck) + (Number_of_teddy_bears * teddy_bear) + (Number_of_talking_dolls * talking_doll) + (Number_of_puzzles * puzzle);

            if (num >= 50)
            {
                double discount = amount- (amount * 25 / 100);
                double total = discount - (discount * 10 / 100);

                if(total >= Price_of_the_trip)
                {
                    double x = (total - Price_of_the_trip);
                    var X = Math.Round(x, 2);

                    Console.WriteLine("Yes! {0} lv left.", X.ToString("0.00"));
                }
                else
                {
                    double x = (Price_of_the_trip - total);
                    var X = Math.Round(x, 2);

                    Console.WriteLine("Not enough money! {0} lv needed.", X.ToString("0.00"));
                }               
            }
            else
            {
                double total = amount - (amount * 10 / 100);

                if (total >= Price_of_the_trip)
                {
                    double x = (total - Price_of_the_trip);
                    var X = Math.Round(x, 2);

                    Console.WriteLine("Yes! {0} lv left.", X.ToString("0.00"));
                }
                else
                {
                    double x = (Price_of_the_trip - total);
                    var X = Math.Round(x, 2);

                    Console.WriteLine("Not enough money! {0} lv needed.", X.ToString("0.00"));
                }
            }
        }
    }
}
