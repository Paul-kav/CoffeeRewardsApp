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
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("***************************");
                Console.WriteLine("* Select from the options *");
                Console.WriteLine("***************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1: Enter Customer");
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
                        CalculateTotalSpent();
                        break;
                    case "3":
                        CalculateCustomerRewards();
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
            Console.ReadLine();
    
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

            Console.WriteLine("Employee created!\n\n");
        }

        private static void CalculateTotalSpent()
        {
            Console.WriteLine("Select a customer");
            for (int i = 1; i <= customers.Count; i++)
            {
                Console.WriteLine($"{i}. {customers[i - 1].FirstName} {customers[i - 1].LastName}");
            }

            int selection = int.Parse(Console.ReadLine());

            Console.Write("Enter the customer's purchases: ");
            int purchase = int.Parse(Console.ReadLine());

            Customer selectedCustomer = customers[selection - 1];
            int priceOfItemPurchased = selectedCustomer.AddPurchase(purchase);
            Console.WriteLine($"{selectedCustomer.FirstName} {selectedCustomer.LastName} has spent {priceOfItemPurchased} dollars.\n\n");

        }

        private static void CalculateCustomerRewards()
        {
            //Console.WriteLine("Select a customer");
            //for (int i = 1; i <= customers.Count; i++)
            //{
            //    Console.WriteLine($"{i}. {customers[i - 1].FirstName} {customers[i - 1].LastName}");
            //}

            //int selection = int.Parse(Console.ReadLine());

            //Customer selectedCustomer = customers[selection - 1];
            //int itemsPurchased;
            //double rewards = selectedCustomer.CalculateRewards(out rewards);

            //Console.WriteLine($"{selectedCustomer.FirstName} {selectedCustomer.LastName} has {rewards}. {itemsPurchased}");
        }

        private static void DisplayCustomerInformation()
        {
            //();
        }


    }
}
