using System;
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
        public double Points { get; set; }
        public int TotalSpent { get; set; }
        public int PriceOfItemPurchased { get; set; }
        public int NumberOfItems { get; set; }

        public Customer(int id, string firstName, string lastName, string email, double points)
        {
            CustomerId = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            Points = points;
            //CustomerTyp = customerTyp;
        }

        public double CalculateTotalSpent()
        {
            double totalPurchase = PriceOfItemPurchased * NumberOfItems;
            
            return totalPurchase;
        }

        public void CalculateRewards()
        {
            double rewards = NumberOfOrdersPlaced / Points;
            Console.WriteLine($"{FirstName} {LastName} got {Points} rewards.");
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"\nId: {CustomerId}\nFirst name: {FirstName}\nLast name: {LastName}\nEmail Address: {EmailAddress}\nRewards: {Points}");
        }

    }
}
