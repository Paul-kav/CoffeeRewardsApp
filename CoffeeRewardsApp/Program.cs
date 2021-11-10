using System;
using System.Collections.Generic;

namespace CoffeeRewardsApp
{
    class Program
    {

        private static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************************");
            Console.WriteLine("* Welcome To My Coffee Rewards Application *");
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Green;

           string userSelection;

            do
            {
                Console.WriteLine("***************************");
                Console.WriteLine("* Select from the options *");
                Console.WriteLine("***************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Choose Customer");
                Console.WriteLine("2: Show total spent");
                Console.WriteLine("3: Show customer rewards");
                Console.WriteLine("4: Display customer details");
                Console.WriteLine("6: Quit application");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        RecordCustomer();
                        break;
                    case "2":
                        ShowTotalSpent();
                        break;
                    case "3":
                        ShowCustomerRwewards();
                        break;
                    case "4":
                        DisplayCustomerInformation();
                        break;
                    case "6": break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            while (userSelection != "6");

            Console.WriteLine("Thanks for using my application");
            Console.Read();

            





            //Customer paul = new Customer(004, "Paul", "Kavuma", "paul@gmail.com", 12);
            //Gold peter = new Gold(005, "Peter", "Khan", "peterkhan@me.com", 2);

            //paul.DisplayCustomerDetails();
            //peter.CalculateRewards();
            //peter.DisplayCustomerDetails();




            //Console.ReadLine();
        }
        private static void RecordCustomer()
        {
            Console.Write("Creating Customer");
            //Console.WriteLine("Enter the customer Id: ");
            //double id = double.Parse(Console.ReadLine());

            Console.Write("Enter the customer's first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter the customer's last name: ");
            string lastname = Console.ReadLine();

            Console.Write("Enter customer email address: ");
            string email = Console.ReadLine();

            Console.Write("Enter customer rewards: ");
            string reward = Console.ReadLine();
            double rewards = double.Parse(reward);

            Customer customer = new Customer(firstname, lastname, email, rewards);
            customers.Add(customer);


        }

        private static void ShowTotalSpent()
        {
            throw new NotImplementedException();
        }

        private static void ShowCustomerRwewards()
        {
            throw new NotImplementedException();
        }

        private static void DisplayCustomerInformation()
        {
            throw new NotImplementedException();
        }


    }
}
