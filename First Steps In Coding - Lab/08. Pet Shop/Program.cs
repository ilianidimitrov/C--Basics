using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_dogs = int.Parse(Console.ReadLine());
            int other_animals = int.Parse(Console.ReadLine());

            double value = number_of_dogs * 2.5 + other_animals * 4;

            Console.WriteLine(Math.Round(value, 2) + " lv.");
        }
    }
}
