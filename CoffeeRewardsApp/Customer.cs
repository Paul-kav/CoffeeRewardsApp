using System;
namespace CoffeeRewardsApp
{
    public class Customer
    {
        public Customer()
        {
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int NumberOfOrdersPlaced { get; set; }
        public double Reward { get; set; }
        public int TotalSpent { get; set; }
        public int PriceOfItemPurchased { get; set; }
        public int  NumberOfItems { get; set; }

        public void CalculateTotalPriceOfItemsPurchased()
        {
            int total = PriceOfItemPurchased * NumberOfItems; 
        }

        public void CalculateRewards()
        {
            double rewards = NumberOfOrdersPlaced / Reward;
            Console.WriteLine($"{FirstName} {LastName} got {Reward} rewards.");
        }

        public void DisplayCustomerDetails()
        {

        }

    }
}
