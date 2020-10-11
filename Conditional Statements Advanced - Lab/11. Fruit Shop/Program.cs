using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amont = double.Parse(Console.ReadLine());

            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 2.50;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * 2.70;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 1.20;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * 1.25;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 0.85;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * .90;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 1.45;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * 1.60;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 2.70;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * 3.00;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 5.50;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * 5.60;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            double X = amont * 3.85;
                            Console.WriteLine(X.ToString("0.00"));
                            break;
                        case "Saturday":
                        case "Sunday":
                            double X_wek = amont * 4.20;
                            Console.WriteLine(X_wek.ToString("0.00"));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }          
        }
    }
}
