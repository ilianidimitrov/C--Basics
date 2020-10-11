using System;

namespace _06._Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", fname, lname, age, town);
        }
    }
}
