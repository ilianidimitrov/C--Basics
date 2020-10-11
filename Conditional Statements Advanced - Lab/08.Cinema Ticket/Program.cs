using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            int tick = 12, tick1 = 14, tick2 = 16;
            switch (day)
            {
                case "Monday":
                    Console.WriteLine(tick);
                    break;
                case "Tuesday":
                    Console.WriteLine(tick);
                    break;
                case "Wednesday":
                    Console.WriteLine(tick1);
                    break;
                case "Thursday":
                    Console.WriteLine(tick1);
                    break;
                case "Friday":
                    Console.WriteLine(tick);
                    break;
                case "Saturday":
                    Console.WriteLine(tick2);
                    break;
                case "Sunday":
                    Console.WriteLine(tick2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
