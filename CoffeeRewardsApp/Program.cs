using System;
using System.Collections.Generic;

namespace CoffeeRewardsApp
{
    class Program
    {

        //private static List<Customer> customer = new List<Customer>();

        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("************");
            Console.WriteLine("****** Welcome to my Coffee rewards application ******");

            
            Customer paul = new Customer(004, "Paul", "Kavuma", "paul@gmail.com", 12);
            Gold peter = new Gold(005, "Peter", "Khan", "peterkhan@me.com", 28);
            
            paul.DisplayCustomerDetails();
            peter.DisplayCustomerDetails();
            Console.ReadLine();
        }

    }
}
