using System;
namespace CoffeeRewardsApp
{
    public class Bronze : Customer
    {
        public Bronze(string firstName, string lastName, string email, double points) : base(firstName, lastName, email, points)
        {
        }

        public void CalcReward()
        {
            var rewards = RewardPoints + 1;
            RewardPoints = rewards;
            Console.WriteLine($"{FirstName} {LastName} got {rewards} rewards.");
        }
    }
}
