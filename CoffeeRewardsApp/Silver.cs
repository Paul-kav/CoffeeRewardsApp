using System;
namespace CoffeeRewardsApp
{
    public class Silver : Customer
    {
        public Silver(string firstName, string lastName, string email, double points) : base(firstName, lastName, email, points)
        {
        }

        public void CalcReward()
        {
            var rewards = RewardPoints + 2;
            RewardPoints = rewards;
            Console.WriteLine($"{FirstName} {LastName} got {rewards} reward points.");
        }

    }
}
