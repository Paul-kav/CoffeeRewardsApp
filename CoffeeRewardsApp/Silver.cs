using System;
namespace CoffeeRewardsApp
{
    public class Silver : Customer
    {
        public Silver(int id, string firstName, string lastName, string email, double points) : base(id, firstName, lastName, email, points)
        {
        }

        private void CalcReward()
        {
            double rewards = NumberOfOrdersPlaced + NumberOfItems / RewardPoints * 1;
            Console.WriteLine($"{FirstName} {LastName} got {RewardPoints} rewards.");
        }
        
    }
}
