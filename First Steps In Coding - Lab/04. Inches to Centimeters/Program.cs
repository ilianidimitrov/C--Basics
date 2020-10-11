using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        const double convert = 2.54;
        static void Main(string[] args)
        {
            double input_centimeters = Double.Parse(Console.ReadLine());

            double inches = input_centimeters * convert;

            Console.WriteLine(Math.Round(inches, 2));
        }
    }
}
