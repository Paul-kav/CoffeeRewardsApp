using System;
using System.Collections.Generic;
using System.Linq;
namespace CoffeeRewardsApp
{
    public class Customer
    {
        //public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        //public CustomerType CustomerTyp;

        public int NumberOfOrdersPlaced { get; set; }
        //private decimal  price { get; set; }

        //public decimal Price
        //{
        //    get
        //    {
        //        return price;
        //    }
        //    set
        //    {
        //        price = value;
        //    }
        //}
        public double Rewards { get; set; }

        //public double  Rewards
        //{
        //    get
        //    {
        //        return rewards;
        //    }
        //    set
        //    {
        //        rewards = value;
        //    }
        //}
        //public double TotalSpent { get; set; }
        public int PriceOfItemPurchased { get; set; }
        //public decimal PriceOfItemPurchased
        //{
        //    get
        //    {
        //        return priceOfItemPurchased;
        //    }
        //    set
        //    {
        //        priceOfItemPurchased = value;
        //    }
        //}
        //public int NumberOfItems { get; set; }
        //public double RewardPoints { get; set; }
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

        //public double CalculateRewards(out int itemsPurchased)
        //{
        //    double rewards = PriceOfItemPurchased + NumberOfItems / RewardPoints;
        //    Console.WriteLine($"{FirstName} {LastName} got {Rewards} rewards.");
        //    PriceOfItemPurchased = 0;
        //    itemsPurchased = PriceOfItemPurchased;
        //    return rewards;
        //}

        //public void DisplayCustomerDetails()
        //{
        //    Console.WriteLine($"\nId: {FirstName}\nLast name: {LastName}\nEmail Address: {EmailAddress}\nRewards: {Rewards}");
        //}

    }
}
