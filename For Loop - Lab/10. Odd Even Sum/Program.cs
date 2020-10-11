using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int odd_sum = 0, even_sum = 0;

            for(int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {   
                    even_sum += input;
                }               
                if(i % 2 != 0)
                {
                    odd_sum += input;
                }
                
            }
            if (even_sum == odd_sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", even_sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(even_sum - odd_sum));
            }
        }
    }
}
