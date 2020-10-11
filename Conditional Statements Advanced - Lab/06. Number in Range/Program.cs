using System;

namespace _06._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if(input >= -100 && input <= 100)
            {
                if(input != 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
