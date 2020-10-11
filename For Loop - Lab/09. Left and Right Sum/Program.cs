using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0, sum2 = 0;

            int[] first_array = new int[n];
            int[] second_array = new int[n];

            for (int i = 0; i < first_array.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                first_array[i] = input;
            }

            for (int i = 0; i < first_array.Length; i++)
            {
                sum1 += first_array[i];
            }

            for (int i = 0; i < second_array.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                second_array[i] = input;
            }

            for (int i = 0; i < second_array.Length; i++)
            {
                sum2 += second_array[i];
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            } else if (sum1 != sum2)
            {
                int x = sum1 - sum2;
                Console.WriteLine("No, diff = " + Math.Abs(x));
            }

        }    
    }
}
