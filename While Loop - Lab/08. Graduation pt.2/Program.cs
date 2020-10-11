using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Този код работи по същия начин
            //List<double> assessment = new List<double>();

            //string name = Console.ReadLine();

            //while (true)
            //{
            //    double rating = double.Parse(Console.ReadLine());

            //    if (rating < 4)
            //    {
            //        Console.WriteLine("{0} has been excluded at {1} grade", name, assessment.Count + 1);
            //        break; 
            //    }
            //    assessment.Add(Math.Abs(rating));
            //    if (assessment.Count == 12)
            //    {
            //        double average = assessment.Average();
            //        Console.WriteLine("{0} graduated. Average grade: {1}", name, average.ToString("0.00"));
            //        break;
            //    }
            //}

            string name = Console.ReadLine();

            int n = 0;
            double average = 0;

            while (true)
            {
                double rating = double.Parse(Console.ReadLine());
                if (rating < 4)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade", name, n + 1);
                    break; 
                }
                average += rating;
                n++;
                if(n == 12)
                {
                    average /= 12;
                    Console.WriteLine("{0} graduated. Average grade: {1}", name, average.ToString("0.00"));
                    break;
                }
            }


        }
    }
}