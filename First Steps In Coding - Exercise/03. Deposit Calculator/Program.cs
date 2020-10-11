using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposited_amount = double.Parse(Console.ReadLine());
            int term_of_the_deposit = int.Parse(Console.ReadLine());
            double annual_interest_rate = double.Parse(Console.ReadLine());

            double accrued_interest = (deposited_amount * annual_interest_rate / 100);
            double interest = (accrued_interest / 12);
            double pt = (term_of_the_deposit * interest);
            double total = deposited_amount + pt;

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
