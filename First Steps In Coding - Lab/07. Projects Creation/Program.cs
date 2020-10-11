using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int number_of_project = int.Parse(Console.ReadLine());
            int hours = 3 * number_of_project;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hours, number_of_project);
        }
    }
}
