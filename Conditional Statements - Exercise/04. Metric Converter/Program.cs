using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string output_unit_of_measure = Console.ReadLine();

            if(unit == "mm")
            {
                if(output_unit_of_measure == "cm")
                {
                    double X = number / 10;
                    Console.WriteLine(X.ToString("0.000"));
                }
                else if(output_unit_of_measure == "m")
                {
                    double X = number / 1000;
                    Console.WriteLine(X.ToString("0.000"));
                }
            }
            else if (unit == "cm")
            {
                if (output_unit_of_measure == "mm")
                {
                    double X = number * 10;
                    Console.WriteLine(X.ToString("0.000"));
                }
                else if (output_unit_of_measure == "m")
                {
                    double X = number / 100;
                    Console.WriteLine(X.ToString("0.000"));
                }
            }
            else if(unit == "m")
            {
                if (output_unit_of_measure == "mm")
                {
                    double X = number * 1000;
                    Console.WriteLine(X.ToString("0.000"));
                }
                else if (output_unit_of_measure == "cm")
                {
                    double X = number * 100;
                    Console.WriteLine(X.ToString("0.000"));
                }
            }
        }
    }
}
