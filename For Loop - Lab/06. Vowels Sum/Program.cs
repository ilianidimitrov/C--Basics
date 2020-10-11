using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 0;
            for(int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if(input[i] == 'a')
                {
                    n += 1;
                }
                else if(input[i] == 'e')
                {
                    n += 2;
                }
                else if (input[i] == 'i')
                {
                    n += 3;
                }
                else if (input[i] == 'o')
                {
                    n += 4;
                }
                else if (input[i] == 'u')
                {
                    n += 5;
                }
            }
            Console.WriteLine(n);
        }
    }
}
