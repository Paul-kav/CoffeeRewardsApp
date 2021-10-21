using System;

namespace CoffeeRewardsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to my reards application ******");

            Customer person = new Customer();
            person.FirstName = "Paul";

            person.CalculateRewards();
            
        }

    }
}
