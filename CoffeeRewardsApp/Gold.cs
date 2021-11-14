using System;
namespace CoffeeRewardsApp
{
    public class Gold : Customer
    {
        private double rewardPoints;
        

        public Gold(string firstName, string lastName, string email, double rewards) : base(firstName, lastName, email, rewards)
        { }

        //public void CalculateRewards()
        //{
        //    rewardPoints = 3;
        //    NumberOfOrdersPlaced = 4;
        //    NumberOfItems = 6;
        //    Rewards = 4 + 6 / 3;
        //    Console.WriteLine($"{FirstName} {LastName} got {Rewards} rewards.");
        //}

        //public new void DisplayCustomerDetails()
        //{
        //    Console.WriteLine($"\nId: {FirstName}\nLast name: {LastName}\nEmail Address: {EmailAddress}\nRewards: {Rewards}");
        //}
    }
}
