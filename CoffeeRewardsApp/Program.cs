using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeRewardsApp
{
    class Program
    {

        private static List<Customer> customers = new List<Customer>();
        private static List<Bronze> bronzeCustomers = new List<Bronze>();
        private static List<Silver> silverCustomers = new List<Silver>();
        private static List<Gold> goldCustomers = new List<Gold>();

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
                        ShowCustomerRewards();
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

        private static void ShowCustomerRewards()
        {
            //select the customer

            //show the selected customer's reward level
            //show the selected customer's reward points
            throw new NotImplementedException();
        }

        private static void RecordCustomer()
        {
            Console.Write("Creating Customer");

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
            SelectCustomer();
            int selection = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter the customer's purchases: ");
            int purchase = int.Parse(Console.ReadLine());

            Customer selectedCustomer = customers[selection];
            selectedCustomer.AddPurchase(purchase);
            selectedCustomer.NumberOfOrdersPlaced++;
            CalculateCustomerRewards(selectedCustomer);
            double purchases = selectedCustomer.TotalSpent();
            var rewardLevel = FindCustomerRewardLevel(selectedCustomer).ToString();
            Console.WriteLine($"{selectedCustomer.FirstName} {selectedCustomer.LastName} has spent {purchases} dollars.\n\n");
            Console.WriteLine($"{selectedCustomer.FirstName} {selectedCustomer.LastName} has earned {selectedCustomer.RewardPoints} reward points.\n\n");
            Console.WriteLine($"{selectedCustomer.FirstName} {selectedCustomer.LastName} is a {rewardLevel} customer.\n\n");
        }

        private static void SelectCustomer()
        {
            Console.WriteLine("Select a customer: ");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {customers[i].FirstName} {customers[i].LastName}");
            }
        }

        private static void CalculateCustomerRewards(Customer selectedCustomer)
        {
            if (selectedCustomer.NumberOfOrdersPlaced > 1 && selectedCustomer.NumberOfOrdersPlaced < 4)
            {
                var customerToUpdate = bronzeCustomers.Find(x => x.FirstName == selectedCustomer.FirstName && x.LastName == selectedCustomer.LastName)
                    ?? new Bronze(selectedCustomer.FirstName, selectedCustomer.LastName, selectedCustomer.EmailAddress, selectedCustomer.Rewards);

                if (bronzeCustomers.All(x => x.FirstName != selectedCustomer.FirstName && x.LastName != selectedCustomer.LastName))
                    bronzeCustomers.Add(customerToUpdate);
                //we don't remove customers from the base list since we need a way to select them.
                customerToUpdate.CalcReward();
                //need to make sure the base customer reflects the changes in their reward version
                selectedCustomer.RewardPoints = customerToUpdate.RewardPoints;
            }
            else if (selectedCustomer.NumberOfOrdersPlaced > 3 && selectedCustomer.NumberOfOrdersPlaced < 6)
            {
                var customerToUpdate = silverCustomers.Find(x => x.FirstName == selectedCustomer.FirstName && x.LastName == selectedCustomer.LastName)
                   ?? new Silver(selectedCustomer.FirstName, selectedCustomer.LastName, selectedCustomer.EmailAddress, selectedCustomer.Rewards);

                silverCustomers.Add(customerToUpdate);
                //need to find the bronze data and remove it
                var bronzeInfo = bronzeCustomers.Find(x => x.FirstName == customerToUpdate.FirstName && x.LastName == customerToUpdate.LastName);

                if (bronzeInfo != null)
                    bronzeCustomers.Remove(bronzeInfo);

                customerToUpdate.CalcReward();
            }
            else if (selectedCustomer.NumberOfOrdersPlaced > 5)
            {
                //find the gold customer information and update it to gold list
                var customerToUpdate = goldCustomers.Find(x => x.FirstName == selectedCustomer.FirstName && x.LastName == selectedCustomer.LastName)
                ?? new Gold(selectedCustomer.FirstName, selectedCustomer.LastName, selectedCustomer.EmailAddress, selectedCustomer.Rewards);
                goldCustomers.Add(customerToUpdate);

                //silver information found and removed from the sliver list
                var silverInfo = silverCustomers.Find(x => x.FirstName == customerToUpdate.FirstName && x.LastName == selectedCustomer.LastName);

                if (silverInfo != null)
                    silverCustomers.Remove(silverInfo);

                customerToUpdate.CalcReward();
                
            }
            
        }

        private static RewardLevelEnum FindCustomerRewardLevel(Customer selectedCustomer)
        {
            var rewardLevel = RewardLevelEnum.New;

            if (bronzeCustomers.Any(x => x.FirstName == selectedCustomer.FirstName && x.LastName == selectedCustomer.LastName))
                rewardLevel = RewardLevelEnum.Bronze;
            else if (silverCustomers.Any(x => x.FirstName == selectedCustomer.FirstName && x.LastName == selectedCustomer.LastName))
                rewardLevel = RewardLevelEnum.Silver;
            else if (goldCustomers.Any(x => x.FirstName == selectedCustomer.FirstName && x.LastName == selectedCustomer.LastName))
                rewardLevel = RewardLevelEnum.Gold;

            return rewardLevel;
        }


        private static void DisplayCustomerInformation()
        {
            throw new NotImplementedException();
        }

    }
}
