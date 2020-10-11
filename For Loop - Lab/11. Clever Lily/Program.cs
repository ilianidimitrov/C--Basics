using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            int num = 0, toy = 0, d = 0, s = 0;
            double The_price_of_the_washing_machine = double.Parse(Console.ReadLine());
            double The_price_of_the_toy = double.Parse(Console.ReadLine());


            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    d = (i / 2) * 10;
                    num += d;
                }               
                if(i % 2 != 0)
                {
                    toy += 1;
                }
            }
            if (age % 2 == 0)
            {
                s = age / 2;
            }
            if (age % 2 != 0)
            {
                s = (age - 1) / 2;
            }
            The_price_of_the_toy *= toy;
            double all = The_price_of_the_toy + num - s;
            if (The_price_of_the_washing_machine <= all)
            {
                Console.WriteLine("Yes! {0}", (all - The_price_of_the_washing_machine).ToString("0.00"));
            }
            else
            {
                Console.WriteLine("No! {0}", (The_price_of_the_washing_machine - all).ToString("0.00"));
            }   
        }
    }
}
