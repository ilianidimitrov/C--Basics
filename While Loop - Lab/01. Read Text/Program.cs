using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "Stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(str);
                }              
            }
        }
    }
}
