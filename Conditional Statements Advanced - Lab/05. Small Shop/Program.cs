using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amont = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia":
                            double price_in_Sofia = amont * 0.50;
                            Console.WriteLine(price_in_Sofia);
                            break;
                        case "Plovdiv":
                            double price_in_Plovdiv = amont * 0.40;
                            Console.WriteLine(price_in_Plovdiv);
                            break;
                        case "Varna":
                            double price_in_Varna = amont * 0.45;
                            Console.WriteLine(price_in_Varna);
                            break;
                    }
                    break;
                case "water":
                    switch (city)
                    {
                        case "Sofia":
                            double price_in_Sofia = amont * 0.80;
                            Console.WriteLine(price_in_Sofia);
                            break;
                        case "Plovdiv":
                            double price_in_Plovdiv = amont * 0.70;
                            Console.WriteLine(price_in_Plovdiv);
                            break;
                        case "Varna":
                            double price_in_Varna = amont * 0.70;
                            Console.WriteLine(price_in_Varna);
                            break;
                    }
                    break;
                case "beer":
                    switch (city)
                    {
                        case "Sofia":
                            double price_in_Sofia = amont * 1.20;
                            Console.WriteLine(price_in_Sofia);
                            break;
                        case "Plovdiv":
                            double price_in_Plovdiv = amont * 1.15;
                            Console.WriteLine(price_in_Plovdiv);
                            break;
                        case "Varna":
                            double price_in_Varna = amont * 1.10;
                            Console.WriteLine(price_in_Varna);
                            break;
                    }
                    break;
                case "sweets":
                    switch (city)
                    {
                        case "Sofia":
                            double price_in_Sofia = amont * 1.45;
                            Console.WriteLine(price_in_Sofia);
                            break;
                        case "Plovdiv":
                            double price_in_Plovdiv = amont * 1.30;
                            Console.WriteLine(price_in_Plovdiv);
                            break;
                        case "Varna":
                            double price_in_Varna = amont * 1.35;
                            Console.WriteLine(price_in_Varna);
                            break;
                    }
                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "Sofia":
                            double price_in_Sofia = amont * 1.60;
                            Console.WriteLine(price_in_Sofia);
                            break;
                        case "Plovdiv":
                            double price_in_Plovdiv = amont * 1.50;
                            Console.WriteLine(price_in_Plovdiv);
                            break;
                        case "Varna":
                            double price_in_Varna = amont * 1.55;
                            Console.WriteLine(price_in_Varna);
                            break;
                    }
                    break;
            }
        }
    }
}
