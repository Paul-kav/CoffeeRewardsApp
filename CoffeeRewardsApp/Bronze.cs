﻿using System;
namespace CoffeeRewardsApp
{
    public class Bronze : Customer
    {
        public Bronze(int id, string firstName, string lastName, string email, double points) : base(id, firstName, lastName, email, points)
        {
        }

        private void CalcReward()
        {
            double rewards = NumberOfOrdersPlaced + NumberOfItems / RewardPoints * 0.25;
            Console.WriteLine($"{FirstName} {LastName} got {RewardPoints} rewards.");
        }
    }
}