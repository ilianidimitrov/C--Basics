using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstTime = int.Parse(Console.ReadLine());
            int SecondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());

            int totalTimes = FirstTime + SecondTime + ThirdTime;

            int minutes = totalTimes / 60;
            int secounds = totalTimes % 60;

            if (secounds < 10)
            {
                Console.WriteLine($"{minutes}:0{secounds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secounds}");
            }
        }
    }
}
