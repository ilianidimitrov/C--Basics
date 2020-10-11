using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int total = a * b * c;

            int n = 0;

            while (true)
            {
                string number = Console.ReadLine();
                if (number == "Done")
                {
                    int remains = total - n;
                    Console.WriteLine("{0} Cubic meters left.", remains);
                    break;
                }
                int length = 0;
                int.TryParse(number, out length);
                n += length;

                if(n > total)
                {
                    int remains = n - total;
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", remains);
                    break;
                }

                
            }
        }
    }
}
