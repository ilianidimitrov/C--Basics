using System;
using System.Linq;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int []arr_of_numbers = new int[n];
            
            for(int i = 0; i < arr_of_numbers.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                arr_of_numbers[i] = input;
            }
            Console.WriteLine("Max number: " + arr_of_numbers.Max());
            Console.WriteLine("Min number: " + arr_of_numbers.Min());
        }
    }
}
