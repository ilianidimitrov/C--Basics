using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales_volume = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia":
                    if(0 <= sales_volume && sales_volume <= 500)
                    {
                        double X = (sales_volume * 5 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if(500 < sales_volume && sales_volume <= 1000)
                    {
                        double X =(sales_volume * 7 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if(1000 < sales_volume && sales_volume <= 10000)
                    {
                        double X =(sales_volume * 8 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if(10000 < sales_volume)
                    {
                        double X =(sales_volume * 12 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (0 <= sales_volume && sales_volume <= 500)
                    {
                        double X = (sales_volume * 4.5 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if (500 < sales_volume && sales_volume <= 1000)
                    {
                        double X =(sales_volume * 7.5 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if (1000 < sales_volume && sales_volume <= 10000)
                    {
                        double X =(sales_volume * 10 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if (10000 < sales_volume)
                    {
                        double X =(sales_volume * 13 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales_volume && sales_volume <= 500)
                    {
                        double X =(sales_volume * 5.5 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if (500 < sales_volume && sales_volume <= 1000)
                    {
                        double X =(sales_volume * 8 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if (1000 < sales_volume && sales_volume <= 10000)
                    {
                        double X =(sales_volume * 12 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else if (10000 < sales_volume)
                    {
                        double X =(sales_volume * 14.5 / 100);
                        Console.WriteLine(X.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
