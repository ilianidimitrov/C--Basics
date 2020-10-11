using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int n = 0;

            while (true)
            {
                int nums = int.Parse(Console.ReadLine());
                n += nums;
                if(n >= input)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
        }
    }
}
