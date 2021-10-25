using System;
namespace CoffeeRewardsApp
{
    public class Gold : CustomerType
    {
        public Gold(int id, string first, string last, string email, double points) : base(id, first, last, email, points)
        {
        }
    }
}
