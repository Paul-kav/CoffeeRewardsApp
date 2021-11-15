using System;
namespace CoffeeRewardsApp
{
    public class Gold : Customer
    {
        //private double rewardPoints;
        

        public Gold(string firstName, string lastName, string email, double rewards) : base(firstName, lastName, email, rewards)
        { }

        public new void CalculateRewards()
        {
            var reward = RewardPoints + 4;
            RewardPoints = reward;
            Console.WriteLine($"{FirstName} {LastName} got {reward} reward points.");
        }
    }
}
