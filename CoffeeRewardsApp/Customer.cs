using System;
namespace CoffeeRewardsApp
{
    public class Customer
    {
        public Customer()
        {
        }

        public string customerId;
        public string emailAddress;
        public string firstName;
        public string lastName; 

        public int numberOfOrdersPlaced;
        public double reward;
        public int priceOfpurchasedItems;
        public DateTime dateOfPurchase;

        public void CalculateRewards()
        {
            double rewards = numberOfOrdersPlaced / reward;
            Console.WriteLine($"{firstName} {lastName} got {reward} rewards.");
        }
    }
}
