using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            double total = ((length * width * height) * 0.001) * (1 - percentage);

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
