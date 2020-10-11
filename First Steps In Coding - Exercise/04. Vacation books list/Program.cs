using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_pages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int number_of_days = int.Parse(Console.ReadLine());

            double hours = number_of_pages / pages;
            double total = hours / number_of_days;

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
