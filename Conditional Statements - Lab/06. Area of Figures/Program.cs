using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = a * a;
                Console.WriteLine(Math.Round(S, 3).ToString("0.000"));
            }
            else if (input == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine(Math.Round(S, 3).ToString("0.000"));
            }
            else if (input == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double x = Math.PI * r * r;
                Console.WriteLine(Math.Round(x, 3).ToString("0.000"));
            }
            else if (input == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = (a * b) / 2;
                Console.WriteLine(Math.Round(S, 3).ToString("0.000"));
            }
        }
    }
}
