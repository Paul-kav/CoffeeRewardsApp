using System;
namespace CoffeeRewardsApp
{
    public class Gold : Customer
    {
        private double rewardPoints;
        

        public Gold(int id, string firstName, string lastName, string email, double rewards) : base(id, firstName, lastName, email, rewards)
        { }

        public new void CalculateRewards()
        {
            rewardPoints = 3;
            NumberOfOrdersPlaced = 4;
            NumberOfItems = 6;
            Rewards = 4 + 6 / 3;
            Console.WriteLine($"{FirstName} {LastName} got {Rewards} rewards.");
        }
    }
}
