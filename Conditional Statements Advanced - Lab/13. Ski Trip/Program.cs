using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();

            days -= 1;

            switch (type)
            {
                case "room for one person":
                    if(days <= 10)
                    {
                        double x = days * 18.00;
                        if(rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }else if(rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    else if(10 < days && days <= 15)
                    {
                        double x = days * 18.00;
                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    else if (15 < days)
                    {
                        double x = days * 18.00;
                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                        break;
                case "apartment":
                    if (days <= 10)
                    {
                        double x = (days * 25.00) - ((days * 25.00) * 30 /100);

                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    else if (10 < days && days <= 15)
                    {
                        double x = (days * 25.00) - ((days * 25.00) * 35 / 100);
                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    else if (15 < days)
                    {
                        double x = (days * 25.00) - ((days * 25.00) * 50 / 100);
                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    break;
                case "president apartment":
                    if (days <= 10)
                    {
                        double x = (days * 35.00) - ((days * 35.00) * 10 / 100);

                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    else if (10 < days && days <= 15)
                    {
                        double x = (days * 35.00) - ((days * 35.00) * 15 / 100);
                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    else if (15 < days)
                    {
                        double x = (days * 35.00) - ((days * 35.00) * 20 / 100);
                        if (rating == "positive")
                        {
                            double X = x + (x * 25 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                        else if (rating == "negative")
                        {
                            double X = x - (x * 10 / 100);
                            Console.WriteLine(X.ToString("0.00"));
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
