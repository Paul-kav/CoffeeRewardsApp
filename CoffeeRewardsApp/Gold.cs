using System;
namespace CoffeeRewardsApp
{
    public class Gold : Customer
    {
        public Gold(int id, string firstName, string lastName, string email, double points) : base(id, firstName, lastName, email, points)
        { }
        
    }
}
