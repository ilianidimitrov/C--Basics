using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i <= n; i++)
            {

                for (int j = 0; j <= n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k <= n; k++)
                    {
                        sum = i + j + k;
                        if (sum == n)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
