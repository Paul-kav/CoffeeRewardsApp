﻿using System;
namespace CoffeeRewardsApp
{
    public class Silver : Customer
    {
        public Silver(string firstName, string lastName, string email, double points) : base(firstName, lastName, email, points)
        {
        }

        //public void CalcReward()
        //{
        //    double rewards = NumberOfOrdersPlaced + NumberOfItems / RewardPoints * 1;
        //    Console.WriteLine($"{FirstName} {LastName} got {RewardPoints} rewards.");
        //}
        
    }
}
