using System;
using System.Collections.Generic;
using System.Linq;
namespace CoffeeRewardsApp
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        //public CustomerType CustomerTyp;

        public int NumberOfOrdersPlaced { get; set; }
        public double Rewards { get; set; }
        //public double TotalSpent { get; set; }
        public int PriceOfItemPurchased { get; set; }
        public int NumberOfItems { get; set; }
        public double RewardPoints { get; set; }
        public List<double> Purchases = new List<double>();

        public Customer(string firstName, string lastName, string email, double rewards)
        {
           // CustomerId = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            Rewards = rewards;
            //CustomerTyp = customerTyp;
        }

        public void AddPurchase( double purchase)
        {

            Purchases.Add(purchase);
            //PriceOfItemPurchased += purchase;
            //return PriceOfItemPurchased;
        }


        public double TotalSpent()
        {

            return Purchases.Sum();
        }

        public void CalculateRewards()
        {
            double rewards = PriceOfItemPurchased + NumberOfItems / RewardPoints;
            Console.WriteLine($"{FirstName} {LastName} got {Rewards} rewards.");
            //PriceOfItemPurchased = 0;
            //itemsPurchased = PriceOfItemPurchased;
            //return rewards;
        }

        //public void DisplayCustomerDetails()
        //{
        //    Console.WriteLine($"\nId: {FirstName}\nLast name: {LastName}\nEmail Address: {EmailAddress}\nRewards: {Rewards}");
        //}

    }
}
