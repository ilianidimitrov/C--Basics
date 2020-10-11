using System;
using System.Collections.Generic;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = n % 2;
            n -= l;
            for(int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
