namespace CoffeeRewardsApp
{
    public class CustomerType : Customer
    {
        //internal static CustomerType Gold;

        public CustomerType(int id, string first, string last, string email, double points) : base(id, first, last, email, points)
        {

        }
    }
}