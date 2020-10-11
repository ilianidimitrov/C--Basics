using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 20 / 100;
            double drinks = cake - (cake * 45 / 100);
            double animator = rent / 3;
            double total = rent + cake + drinks + animator;

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
