using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            while (true)
            {
                string number = Console.ReadLine();
                if(number == "Stop")
                {
                    int[] array = myList.ToArray();
                    Console.WriteLine(array.Max());
                    break;
                }
                double length = 0;
                Double.TryParse(number, out length);
                int l = Convert.ToInt32(length);
                myList.Add(l);
            }
        }
    }
}
